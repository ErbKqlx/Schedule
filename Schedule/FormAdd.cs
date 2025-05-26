using Microsoft.EntityFrameworkCore;
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
    public partial class FormAdd : Form
    {
        private ScheduleContext _db;

        public FormAdd(ScheduleContext db)
        {
            InitializeComponent();
            _db = db;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //доделать
            comboBoxGroups.DataSource = _db.Groups.Local.ToBindingList();
            comboBoxGroups.DisplayMember = "Name";
            comboBoxGroups.ValueMember = "Id";

            comboBoxDisciplines.DataSource = _db.Disciplines.Local.ToBindingList();
            comboBoxDisciplines.DisplayMember = "CodeName";
            comboBoxDisciplines.ValueMember = "Id";

            comboBoxTeachers.DataSource = _db.Teachers.Local.ToBindingList();
            comboBoxTeachers.DisplayMember = "FullName";
            comboBoxTeachers.ValueMember = "Id";

            comboBoxBuildings.DataSource = _db.Buildings.Local.ToBindingList();
            comboBoxBuildings.DisplayMember = "Name";
            comboBoxBuildings.ValueMember = "Id";

            comboBoxCabinets.DataSource = _db.Cabinets.Local.ToBindingList();
            comboBoxCabinets.DisplayMember = "Number";
            comboBoxCabinets.ValueMember = "Id";



        }
    }
}
