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
        private short _id;

        private Panel? selectedPanel;
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
                var idSchedule = schedule.Id;
                var groupName = _db.Groups.FirstOrDefault(v => v.Id == schedule.IdGroup).Name;
                var cabinet = _db.Cabinets.FirstOrDefault(v => v.Id == schedule.IdCabinet);
                var buildingCabinet = _db.Buildings.FirstOrDefault(v => v.Id == cabinet.IdBuilding).ShortName + " " + cabinet.Number + " каб.";
                //label3.Text = schedule.Number.ToString();
                var disciplinesTeacher = _db.DisciplinesTeachers.FirstOrDefault(v => v.Id == schedule.IdDisciplineTeacher);
                var discipline = _db.Disciplines.FirstOrDefault(v => v.Id == disciplinesTeacher.IdDiscipline);
                var disciplineName = $"{discipline.Code} {discipline.Name}";
                var teacher = _db.Teachers.FirstOrDefault(v => v.Id == disciplinesTeacher.IdTeacher);
                var teacherName = $"{teacher.Surname} {teacher.Name} {teacher.Patronymic}";
                //label6.Text = schedule.Date.ToString();
                CreatePanel
                (
                    idSchedule, 
                    groupName,
                    buildingCabinet,
                    disciplineName,
                    teacherName
                );
            }

            var updateMenuItem = new ToolStripMenuItem("Редактировать");
            updateMenuItem.Click += UpdateMenuItem_Click;
            var deleteMenuItem = new ToolStripMenuItem("Удалить");
            deleteMenuItem.Click += DeleteMenuItem_Click;

            if (contextMenuStrip1.Items.Count == 0)
            {
                contextMenuStrip1.Items.AddRange(new[] { updateMenuItem, deleteMenuItem });
            }
        }

        private void UpdateMenuItem_Click(object? sender, EventArgs e)
        {
            var formAdd = new FormAdd();
            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel) { return; }
        }

        private void DeleteMenuItem_Click(object? sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Remove(selectedPanel);

            //selectedPanel = null;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _db?.Dispose();
            _db = null;
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            var panel = sender as Panel;
            _id = short.Parse(panel.Name.Split("_")[1]);

            panel.BackColor = Color.AliceBlue;

            if (panel != selectedPanel && selectedPanel != null)
            {
                selectedPanel.BackColor = DefaultBackColor;
                selectedPanel.ContextMenuStrip = null;
            }
            selectedPanel = panel;
            selectedPanel.ContextMenuStrip = contextMenuStrip1;

        }

        private void CreatePanel(short id, string groupName, string buildingCabinet, string disciplineName, string teacherName)
        {
            var labelCabinet = new Label();
            var labelDiscipline = new Label();
            var labelTeacher = new Label();

            labelCabinet.Text = buildingCabinet;
            labelDiscipline.Text = disciplineName;
            labelTeacher.Text = teacherName;
            // 
            // labelCabinet
            // 
            labelCabinet.Dock = DockStyle.Bottom;
            labelCabinet.Location = new Point(0, 172);
            labelCabinet.Margin = new Padding(5, 0, 5, 0);
            labelCabinet.Name = "labelCabinet";
            labelCabinet.RightToLeft = RightToLeft.No;
            labelCabinet.Size = new Size(193, 25);
            labelCabinet.TabIndex = 1;
            labelCabinet.Text = buildingCabinet;
            labelCabinet.TextAlign = ContentAlignment.BottomRight;
            // 
            // labelTeacher
            // 
            labelTeacher.AutoSize = true;
            labelTeacher.Dock = DockStyle.Top;
            labelTeacher.Location = new Point(0, 35);
            labelTeacher.Margin = new Padding(5, 0, 5, 0);
            labelTeacher.MaximumSize = new Size(193, 0);
            labelTeacher.Name = "labelTeacher";
            labelTeacher.Padding = new Padding(0, 0, 0, 10);
            labelTeacher.Size = new Size(102, 35);
            labelTeacher.TabIndex = 3;
            labelTeacher.Text = teacherName;
            // 
            // labelDiscipline
            // 
            labelDiscipline.AutoSize = true;
            labelDiscipline.Dock = DockStyle.Top;
            labelDiscipline.Location = new Point(0, 0);
            labelDiscipline.Margin = new Padding(5, 0, 5, 0);
            labelDiscipline.MaximumSize = new Size(193, 0);
            labelDiscipline.Name = "labelDiscipline";
            labelDiscipline.Padding = new Padding(0, 0, 0, 10);
            labelDiscipline.Size = new Size(92, 35);
            labelDiscipline.TabIndex = 4;
            labelDiscipline.Text = disciplineName;


            var panel = new Panel();

            // 
            // panel
            // 
            panel.BackColor = Color.WhiteSmoke;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(labelCabinet);
            panel.Controls.Add(labelDiscipline);
            panel.Controls.Add(labelTeacher);
            //panel.Location = new Point(3, 3);
            panel.Name = $"panel_{id}";
            panel.RightToLeft = RightToLeft.No;
            panel.Size = new Size(195, 199);
            panel.TabIndex = 0;
            panel.MouseClick += Panel1_MouseClick;

            flowLayoutPanel1.Controls.Add(panel);
            //panel.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
