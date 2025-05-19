using System.Diagnostics;
using System.Xml;
using System.Xml.Schema;
using Syncfusion.XlsIO;

namespace Schedule
{
    public partial class FormUpload : Form
    {
        private IApplication _application;
        private IWorkbook _workbook;
        private IWorksheet _worksheet;

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
                _application = excelEngine.Excel;

                //Устанавливаем версию по умолчанию
                _application.DefaultVersion = ExcelVersion.Xlsx;

                //Открываем файл
                try
                {
                    _workbook = _application.Workbooks.Open(filename);
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
                

                //Первый лист
                _worksheet = _workbook.Worksheets[0];

                //Чтение ячейки
                var value = _worksheet.Range["B4"].Value;

                //var range = _worksheet.UsedRange;

                MessageBox.Show(value);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _workbook?.SaveAs("Расписание.xlsx");
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
