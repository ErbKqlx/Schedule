using Microsoft.EntityFrameworkCore;
using Schedule_project.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_project
{
    public partial class FormSchedule : Form
    {
        private IApplication _application;
        private IWorkbook _workbook;
        private IWorksheet[] _worksheet;

        private ScheduleContext? _db;
        private short _id;

        private Panel? selectedPanel;
        public FormSchedule(IApplication application, IWorkbook workbook)
        {
            InitializeComponent();
            _application = application;
            _workbook = workbook;
            _worksheet = new IWorksheet[_workbook.Worksheets.Count];
            for (var i = 0; i < _workbook.Worksheets.Count; i++)
            {
                _worksheet[i] = _workbook.Worksheets[i];
            }
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _db = new();

            _db.Teachers.Load();
            _db.Groups.Load();
            _db.Buildings.Load();
            _db.Cabinets.Load();

            short column = 1;
            foreach (var sheet in _worksheet)
            {
                var range = sheet.Range["B3:C14"];
                var group = $"{range["B3"].Text}";
                var date = sheet.Name.Split(' ')[0] + ".2025";
                for (var i = 0; i < 12; i += 2)
                {
                    //пара
                    var pair = range[$"B{4 + i}"].Text;
                    if (pair == null) { continue; }

                    var number = range[$"A{4 + i}"].DisplayText;

                    //дисциплина с преподавателем
                    var regex = new Regex(@"\d", RegexOptions.RightToLeft);
                    var discipline = pair.Split('\n')[0];
                    string? code = null;
                    string name = "";
                    if (regex.IsMatch(discipline))
                    {
                        code = discipline.Substring(0, regex.Match(discipline).Index + 1);
                        name = discipline.Substring(regex.Match(discipline).Index + 2);
                    }
                    else
                    {
                        name = discipline;
                    }

                    var teacherName = pair.Split('\n')[1];

                    Discipline element;
                    if (code != null)
                    {
                        element = _db.Disciplines.FirstOrDefault(v => v.Code == code);
                        if (element == null)
                        {
                            element = new Discipline { Code = code, Name = name };
                            _db.Disciplines.Add(element);
                        }
                    }
                    else
                    {
                        element = _db.Disciplines.FirstOrDefault(v => v.Name == name);
                        if (element == null)
                        {
                            element = new Discipline { Name = name };
                            _db.Disciplines.Add(element);
                        }
                    }
                    _db.SaveChanges();

                    var disciplineTeacher = new DisciplinesTeacher
                    {
                        IdDiscipline = element.Id,
                        IdTeacher = _db.Teachers.Local.FirstOrDefault(v => v.ShortName == teacherName).Id
                    };

                    if (_db.DisciplinesTeachers.FirstOrDefault
                        (
                            v => v.IdDiscipline == disciplineTeacher.IdDiscipline
                            && v.IdTeacher == disciplineTeacher.IdTeacher
                        ) == null)
                    {
                        _db.DisciplinesTeachers.Add(disciplineTeacher);
                        _db.SaveChanges();
                    }


                    _db.Disciplines.Load();
                    _db.DisciplinesTeachers.Load();

                    //кабинет с корпусом
                    var cabinet = range[$"C{4 + i}"].Text;
                    var building = cabinet.Split('\n')[0];
                    cabinet = cabinet.Split('\n')[1];

                    Schedule schedule = new Schedule
                    {
                        IdGroup = _db.Groups.Local.FirstOrDefault(v => v.Name == group).Id,
                        IdCabinet = _db.Cabinets.Local.FirstOrDefault(v =>
                            v.Number == cabinet
                            && v.IdBuilding == _db.Buildings.Local.FirstOrDefault(i => i.ShortName == building).Id
                            ).Id,
                        Number = short.Parse(number),
                        IdDisciplineTeacher = _db.DisciplinesTeachers.Local.FirstOrDefault(v =>
                            v.IdDiscipline == _db.Disciplines.Local.FirstOrDefault(i => i.Code == code).Id
                            && v.IdTeacher == _db.Teachers.Local.FirstOrDefault(v => v.ShortName == teacherName).Id).Id,
                        Date = DateOnly.Parse(date)
                    };

                    if (_db.Schedules.FirstOrDefault
                        (
                            v => v.IdGroup == schedule.IdGroup
                            && v.IdCabinet == schedule.IdCabinet
                            && v.Number == schedule.Number
                            && v.IdDisciplineTeacher == schedule.IdDisciplineTeacher
                            && v.Date == schedule.Date
                        ) == null)
                    {
                        _db.Schedules.Add(schedule);
                        _db.SaveChanges();
                    }
                }

                var schedules = _db.Schedules.Local.Where(v => v.Date == DateOnly.Parse(date)).ToList();

                foreach (var schedule in schedules)
                {
                    var idSchedule = schedule.Id;
                    var groupName = _db.Groups.FirstOrDefault(v => v.Id == schedule.IdGroup).Name;
                    var cabinet = _db.Cabinets.FirstOrDefault(v => v.Id == schedule.IdCabinet);
                    var buildingCabinet = _db.Buildings.FirstOrDefault(v => v.Id == cabinet.IdBuilding).ShortName + " " + cabinet.Number;
                    var number = schedule.Number;
                    var disciplinesTeacher = _db.DisciplinesTeachers.FirstOrDefault(v => v.Id == schedule.IdDisciplineTeacher);
                    var disciplineName = _db.Disciplines.FirstOrDefault(v => v.Id == disciplinesTeacher.IdDiscipline).CodeName;
                    var teacherName = _db.Teachers.FirstOrDefault(v => v.Id == disciplinesTeacher.IdTeacher).FullName;
                    CreatePanel
                    (
                        idSchedule,
                        groupName,
                        buildingCabinet,
                        disciplineName,
                        teacherName,
                        number,
                        column
                    );
                }
                column++;
            }
            

            //cabinets = range[$"C4"].Text.Split('\n');
            //MessageBox.Show(cabinets[0]);
            
            _db.Schedules.Load();

            

            labelDate1.Text = _worksheet[0].Name;
            labelDate2.Text = _worksheet[1].Name;
            labelDate3.Text = _worksheet[2].Name;
            labelDate4.Text = _worksheet[3].Name;
            labelDate5.Text = _worksheet[4].Name;
            labelDate6.Text = _worksheet[5].Name;

            var updateMenuItem = new ToolStripMenuItem("Редактировать");
            updateMenuItem.Click += UpdateMenuItem_Click;
            var deleteMenuItem = new ToolStripMenuItem("Удалить");
            deleteMenuItem.Click += DeleteMenuItem_Click;

            if (contextMenuStrip1.Items.Count == 0)
            {
                contextMenuStrip1.Items.AddRange(new[] { updateMenuItem, deleteMenuItem });
            }

            comboBoxGroups.DataSource = _db.Groups.Local.ToBindingList();
            comboBoxGroups.DisplayMember = "Name";
            comboBoxGroups.ValueMember = "Id";

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var formAdd = new FormAdd(_db);
            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel) { return; }
        }

        private void UpdateMenuItem_Click(object? sender, EventArgs e)
        {
            var formAdd = new FormAdd(_db);
            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel) { return; }
        }

        private void DeleteMenuItem_Click(object? sender, EventArgs e)
        {
            if (_id == null) { return; }

            DialogResult result = MessageBox.Show
            (
                "Вы действительно хотите удалить пару?",
                "Удаление",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No) { return; }

            var schedule = _db.Schedules.Find(_id);
            _db.Schedules.Remove(schedule);

            tableLayoutPanelSchedule.Controls.Remove(selectedPanel);
            selectedPanel = null;

            _db.SaveChanges();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            _db?.Dispose();
            _db = null;
        }

        private void Panel_MouseClick(object sender, MouseEventArgs e)
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

        private void CreatePanel(short id, string groupName, string buildingCabinet, string disciplineName, string teacherName, short number, short column)
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
            panel.Controls.Add(labelTeacher);
            panel.Controls.Add(labelDiscipline);
            //panel.Location = new Point(3, 3);
            panel.Name = $"panel_{id}";
            panel.RightToLeft = RightToLeft.No;
            panel.Size = new Size(195, 199);
            panel.TabIndex = 0;
            panel.MouseClick += Panel_MouseClick;

            tableLayoutPanelSchedule.Controls.Add(panel, column, number);
            //panel.ContextMenuStrip = contextMenuStrip1;
        }

        
    }
}
