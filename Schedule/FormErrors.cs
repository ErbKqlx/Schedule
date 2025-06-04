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
    public partial class FormErrors : Form
    {
        public FormErrors(Dictionary<string, string> dictionary)
        {
            InitializeComponent();
            dataGridViewErrors.DataSource = dictionary.ToList();
            dataGridViewErrors.Columns[0].HeaderText = "Дисциплина";
            dataGridViewErrors.Columns[1].HeaderText = "Кабинет";
        }
    }
}
