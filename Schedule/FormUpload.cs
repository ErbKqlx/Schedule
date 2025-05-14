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
                IApplication application = excelEngine.Excel;

                //������������� ������ �� ���������
                application.DefaultVersion = ExcelVersion.Xlsx;

                //��������� ����
                IWorkbook workbook = application.Workbooks.Open(filename);

                //������ ����
                IWorksheet worksheet = workbook.Worksheets[0];

                //������ ������
                var value = worksheet.Range["B2"].Value;

                MessageBox.Show(value);
            }
        }


    }
}
