using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Syncfusion.XlsIO;
using Syncfusion.XlsIO.Implementation.Shapes;

namespace Schedule_project
{
    public partial class FormUpload : Form
    {
        public FormUpload()
        {
            InitializeComponent();

        }

        private void ButtonUpload_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Загрузка файла";
            dialog.InitialDirectory = @"c:\";
            dialog.Filter = "All files (*.*)|*.*";
            dialog.FilterIndex = 2;
            dialog.RestoreDirectory = true;

            if (dialog.ShowDialog() == DialogResult.Cancel) { return; }

            filename = dialog.FileName;

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                
                //Запускаем Excel
                IApplication application = excelEngine.Excel;

                //Устанавливаем версию по умолчанию
                application.DefaultVersion = ExcelVersion.Xlsx;
                IWorkbook workbook;

                //Открываем файл
                try
                {
                    workbook = application.Workbooks.Open(filename);
                }
                catch (IOException exception)
                {
                    ExceptionHandle("Закройте файл перед тем как загружать его");
                    return;
                }
                catch (ArgumentException exception)
                {
                    ExceptionHandle("Файл недоступен");
                    return;
                }
                catch (NotSupportedException exception)
                {
                    ExceptionHandle("Формат файла не поддерживается");
                    return;
                }
                catch (XmlException exception)
                {
                    ExceptionHandle("Формат файла не поддерживается");
                    return;
                }

                var formSchedule = new FormSchedule(application, workbook);
                this.Owner = formSchedule;
                this.Hide();
                formSchedule.Show();
            }
        }

        private void ExceptionHandle(string errorText)
        {
            MessageBox.Show
            (
                errorText,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}
