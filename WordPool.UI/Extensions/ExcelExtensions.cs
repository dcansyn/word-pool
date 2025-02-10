using ClosedXML.Excel;
using System.Data;
using System.Linq;

namespace WordPool.UI.Extensions
{
    public static class ExcelExtensions
    {
        public static DataTable ConvertExcelToDataTable(this string path)
        {
            using (var workbook = new XLWorkbook(path))
            {
                var sheet = workbook.Worksheets.FirstOrDefault();
                var dt = new DataTable(sheet.Name);
                var rows = sheet.RowsUsed();
                var firstRow = true;

                foreach (var row in rows)
                {
                    if (firstRow)
                    {
                        foreach (var cell in row.CellsUsed())
                            dt.Columns.Add(cell.Value.ToString());

                        firstRow = false;
                    }
                    else
                    {
                        dt.Rows.Add();
                        var index = -1;
                        foreach (var cell in row.CellsUsed())
                        {
                            index++;

                            var value = cell.Value.ToString();
                            if (value.StartsWith("="))
                                continue;

                            dt.Rows[dt.Rows.Count - 1][index] = cell.Value.ToString();
                        }
                    }
                }

                return dt;
            }
        }
    }
}
