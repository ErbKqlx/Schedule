using System.Data;
using Microsoft.Office.Interop.Excel;

namespace Schedule
{
    static class ExcelFileReader
    {
        public static System.Data.DataTable read(Microsoft.Office.Interop.Excel.Range excelRange)
        {
            DataRow row;
            System.Data.DataTable dt = new System.Data.DataTable();
            int rowCount = excelRange.Rows.Count; //get row count of excel data
            int colCount = excelRange.Columns.Count; // get column count of excel data
            //Get the first Column of excel file which is the Column Name
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    dt.Columns.Add(excelRange.Cells[i, j].ToString());
                }
                break;
            }
            //Get Row Data of Excel
            int rowCounter; //This variable is used for row index number
            for (int i = 2; i <= rowCount; i++) //Loop for available row of excel data
            {
                row = dt.NewRow(); //assign new row to DataTable
                rowCounter = 0;
                for (int j = 1; j <= colCount; j++) //Loop for available column of excel data
                {
                    //check if cell is empty
                    if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j] != null)
                    {
                        row[rowCounter] = excelRange.Cells[i, j].ToString();
                    }
                    else
                    {
                        row[i] = "";
                    }
                    rowCounter++;
                }
                dt.Rows.Add(row); //add row to DataTable
            }
            return dt;
        }
    }
}
