using System;
using System.Data;
using System.IO;
using ClosedXML.Excel;

namespace Algorithm.Helpers
{
    public static class ExcelFile
    {
        public static XLWorkbook GenerateExcelFile(DataTable dataTable, string path)
        {
            try
            {
                FileInfo TheFileInfo = new FileInfo(path);
                if (TheFileInfo.Exists)
                {
                    File.Delete(path);
                }

                DataSet dataSet = new DataSet();
                dataSet.Tables.Add(dataTable);
                var excelWorkBook = new XLWorkbook();

                excelWorkBook.Worksheets.Add(dataTable);
                excelWorkBook.SaveAs(path);
                return excelWorkBook;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}