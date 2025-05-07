using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Schedule
{
    public partial class FormUpload : System.Windows.Forms.Form
    {
        public FormUpload()
        {
            InitializeComponent();
        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            string file = ""; //variable for the Excel File Location
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.

            if (result == DialogResult.OK) // Check if Result == "OK".
            {
                file = openFileDialog1.FileName; //get the filename with the location of the file
                try
                {
                    //Create Object for Microsoft.Office.Interop.Excel that will be use to read excel file
                    Microsoft.Office.Interop.Excel.Application excelApp =
                        new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(file);
                    Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = (_Worksheet)excelWorkbook.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

                    dataGridView1.DataSource = ExcelFileReader.read(excelRange);
                    //close and clean excel process
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(excelRange);
                    Marshal.ReleaseComObject(excelWorksheet);
                    //quit apps
                    excelWorkbook.Close();
                    Marshal.ReleaseComObject(excelWorkbook);
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
