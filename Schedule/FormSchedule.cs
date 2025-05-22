using Microsoft.EntityFrameworkCore;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_project
{
    public partial class FormSchedule : Form
    {
        private IApplication _application;
        private IWorkbook _workbook;
        private IWorksheet _worksheet;

        private ScheduleContext _db;
        public FormSchedule(IApplication application, IWorkbook workbook)
        {
            InitializeComponent();
            _application = application;
            _workbook = workbook;
            _worksheet = _workbook.Worksheets[0];
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _db = new();
            _db.Schedules.Load();

            date1.Text = _worksheet.Name;

            var schedules = _db.Schedules.Local.ToList();
            foreach (var schedule in schedules)
            {
                labelGroup.Text = _db.Groups.FirstOrDefault(v => v.Id == schedule.IdGroup).Name;
                labelCabinet.Text = _db.Cabinets.FirstOrDefault(v => v.Id == schedule.IdCabinet).Number.ToString();
                //label3.Text = schedule.Number.ToString();
                var disciplinesTeacher = _db.DisciplinesTeachers.FirstOrDefault(v => v.Id == schedule.IdDisciplineTeacher);
                var discipline = _db.Disciplines.FirstOrDefault(v => v.Id == disciplinesTeacher.IdDiscipline);
                labelDiscipline.Text = $"{discipline.Code} {discipline.Name}";
                var teacher = _db.Teachers.FirstOrDefault(v => v.Id == disciplinesTeacher.IdTeacher);
                labelTeacher.Text = $"{teacher.Surname} {teacher.Name} {teacher.Patronymic}";
                //label6.Text = schedule.Date.ToString();
            } 
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _db?.Dispose();
            _db = null;
        }
    }
}
