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
                //excelWorkbook app(package)
                var excelWorkBook = new XLWorkbook();
                //datatable adding to worksheet
                excelWorkBook.Worksheets.Add(dataTable);
                //saving to specified path
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