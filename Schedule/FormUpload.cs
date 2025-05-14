using Syncfusion.XlsIO;

namespace Schedule
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

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filename = dialog.FileName;
            }

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Запускаем Excel
                IApplication application = excelEngine.Excel;

                //Устанавливаем версию по умолчанию
                application.DefaultVersion = ExcelVersion.Xlsx;

                //Открываем файл
                IWorkbook workbook = application.Workbooks.Open(filename);

                //Первый лист
                IWorksheet worksheet = workbook.Worksheets[0];

                //Чтение ячейки
                var value = worksheet.Range["B2"].Value;

                MessageBox.Show(value);
            }
        }


    }
}
