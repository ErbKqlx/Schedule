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

        public short selectedGroupId;
        
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

            _db.Database.ExecuteSqlRaw("TRUNCATE TABLE schedule");

            _db.Teachers.Load();
            _db.Groups.Load();
            _db.Buildings.Load();
            _db.Cabinets.Load();

            short column = 1;
            foreach (var sheet in _worksheet)
            {
                var range = sheet.Range["A3:C14"];
                var date = sheet.Range["J1"].Text.Split(' ')[2];
                for (var i = 1; i < range.Columns.Length; i+=2)
                {
                    var group = range.Columns[i].Rows[0].Text;
                    if (group == null)
                    {
                        i--;
                        continue;
                    }
                    
                    for (var j = 1; j < range.Rows.Length; j++)
                    {
                        //пара
                        var pair = range.Columns[i].Rows[j].Text;
                        if (pair == null) { continue; }

                        var number = range.Columns[0].Rows[j].DisplayText;

                        if (number == "")
                        {
                            number = range.Columns[0].Rows[j-1].DisplayText;
                        }

                        //дисциплина с преподавателем
                        var regexCode = new Regex(@"(?<=\.\d+)\d\s");
                        var discipline = pair.Substring(0, pair.LastIndexOf('\n'));
                        var teacherName = pair.Substring(pair.LastIndexOf('\n')+1);

                        var teacher = _db.Teachers.Local.FirstOrDefault(v => v.ShortName == teacherName);
                        if (teacher == null)
                        {
                            discipline = pair;
                            teacherName = null;
                        }


                        string? code = null;
                        string name = "";

                        

                        if (regexCode.IsMatch(discipline))
                        {
                            code = discipline.Substring(0, regexCode.Match(discipline).Index + 1);
                            name = discipline.Substring(regexCode.Match(discipline).Index + 2);
                        }
                        else
                        {
                            name = discipline;
                        }

                        Discipline element;
                        if (code != null)
                        {
                            element = _db.Disciplines.FirstOrDefault(v => v.Code == code && v.Name == name);
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
                            IdTeacher = teacher?.Id
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
                        var cabinet = range.Columns[i+1].Rows[j].Text;
                        string? building;
                        if (cabinet != "ДТиО" && cabinet != "УПМ" && cabinet != null)
                        {
                            building = cabinet.Split('\n')[0];
                            cabinet = cabinet.Split('\n')[1];
                        }
                        else
                        {
                            cabinet = null;
                            building = null;
                        }

                        Schedule schedule = new Schedule
                        {
                            IdGroup = _db.Groups.Local.FirstOrDefault(v => v.Name == group).Id,
                            IdCabinet = _db.Cabinets.Local.FirstOrDefault(v =>
                                v.Number == cabinet
                                && v.IdBuilding == _db.Buildings.Local.FirstOrDefault(i => i.ShortName == building)?.Id
                                )?.Id,
                            Number = short.Parse(number),
                            IdDisciplineTeacher = _db.DisciplinesTeachers.Local.FirstOrDefault(v =>
                                v.IdDiscipline == _db.Disciplines.Local.FirstOrDefault(i => i.Code == code && i.Name == name).Id
                                && v.IdTeacher == _db.Teachers.Local.FirstOrDefault(v => v.ShortName == teacherName)?.Id).Id,
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
                }
                

                var schedules = _db.Schedules.Local.Where(v => v.Date == DateOnly.Parse(date)).ToList();

                foreach (var schedule in schedules)
                {
                    var idSchedule = schedule.Id;
                    var groupName = _db.Groups.FirstOrDefault(v => v.Id == schedule.IdGroup).Name;
                    var cabinet = _db.Cabinets.FirstOrDefault(v => v.Id == schedule.IdCabinet);
                    string? buildingCabinet = null;
                    if (cabinet != null)
                    {
                        buildingCabinet = _db.Buildings.FirstOrDefault(v => v.Id == cabinet.IdBuilding).ShortName + " " + cabinet.Number;
                    }
                    //var buildingCabinet = _db.Buildings.FirstOrDefault(v => v.Id == cabinet.IdBuilding).ShortName + " " + cabinet.Number;
                    var number = schedule.Number;
                    var disciplinesTeacher = _db.DisciplinesTeachers.FirstOrDefault(v => v.Id == schedule.IdDisciplineTeacher);
                    var disciplineName = _db.Disciplines.FirstOrDefault(v => v.Id == disciplinesTeacher.IdDiscipline).CodeName;
                    var teacher = _db.Teachers.FirstOrDefault(v => v.Id == disciplinesTeacher.IdTeacher);
                    string? teacherName = null;
                    if (teacher != null)
                    {
                        teacherName = teacher.FullName;
                    }
                    bool subgroup = false;
                    if (Regex.IsMatch(disciplineName, @"п/гр"))
                    {
                        subgroup = true;
                    }
                    CreatePanel
                    (
                        idSchedule,
                        groupName,
                        buildingCabinet,
                        disciplineName,
                        teacherName,
                        number,
                        column,
                        subgroup
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

            selectedGroupId = (short)comboBoxGroups.SelectedValue;

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

        private void CreatePanel(short id, string groupName, string buildingCabinet, string disciplineName, string teacherName, short number, short column, bool subgroup)
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
            labelCabinet.TabIndex = 1;
            labelCabinet.Text = buildingCabinet;
            labelCabinet.AutoSize = true;
            labelCabinet.MaximumSize = new Size(180, 50);
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

            var tableLayoutPanel = new TableLayoutPanel();
            //tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.RowStyles.Add(new RowStyle());
            tableLayoutPanel.Size = new Size(227, 450);
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            if (subgroup)
            {
                if (tableLayoutPanelSchedule.GetControlFromPosition(column, number) == null)
                {
                    tableLayoutPanelSchedule.Controls.Add(tableLayoutPanel, column, number);
                }
                tableLayoutPanel.Controls.Add(panel);
            }
            else
            {
                tableLayoutPanelSchedule.Controls.Add(panel, column, number);
            }
            
            //panel.ContextMenuStrip = contextMenuStrip1;
        }

        private void ButtonCheckWorkload_Click(object sender, EventArgs e)
        {
            selectedGroupId = 47;

            var hours = _db.Schedules.Local
                .Select(v => new { v.Id, v.IdGroup, v.Date })
                .Where(v => v.IdGroup == selectedGroupId)
                .Count() * 2;

            if (hours > 36)
            {
                MessageBox.Show
                (
                    "Нагрузка больше 36 часов",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                MessageBox.Show
                (
                    "Нагрузка не превышает 36 часов",
                    "Оповещение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
