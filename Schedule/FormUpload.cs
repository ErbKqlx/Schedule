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

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
            }

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Запускаем Excel
                _application = excelEngine.Excel;

                //Устанавливаем версию по умолчанию
                _application.DefaultVersion = ExcelVersion.Xlsx;

                //Открываем файл
                _workbook = _application.Workbooks.Open(filename);

                //Первый лист
                _worksheet = _workbook.Worksheets[0];

                //Чтение ячейки
                var value = _worksheet.Range["B2"].Value;


            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _workbook?.SaveAs("Расписание.xlsx");
        }
    }
}
