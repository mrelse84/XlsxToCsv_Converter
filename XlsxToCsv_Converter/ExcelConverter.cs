using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XlsxToCsv_Converter
{
    public class ExcelConverter
    {
        public bool Converter(string srcFile, string dstFile)
        {
            bool ret = true;
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.DisplayAlerts = false;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Open(srcFile);
                Microsoft.Office.Interop.Excel.Worksheet xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                xlSheet.Select(Type.Missing);
                File.Delete(dstFile);
                wb.SaveAs(dstFile, Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV);
                wb.Close(false);
            }
            catch (Exception ex)
            {
                ret = false;
            }

            return ret;
        }
    }
}
