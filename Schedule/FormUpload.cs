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
            dialog.Title = "�������� �����";
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
                //��������� Excel
                _application = excelEngine.Excel;

                //������������� ������ �� ���������
                _application.DefaultVersion = ExcelVersion.Xlsx;

                //��������� ����
                _workbook = _application.Workbooks.Open(filename);

                //������ ����
                _worksheet = _workbook.Worksheets[0];

                //������ ������
                var value = _worksheet.Range["B2"].Value;


            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            _workbook?.SaveAs("����������.xlsx");
        }
    }
}
