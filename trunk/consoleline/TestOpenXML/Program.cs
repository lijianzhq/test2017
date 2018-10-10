using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TestOpenXML
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            var helper = new ExcelHelper2();
            helper.CreatePackage(@"d:\11.xlsx");
            Console.WriteLine("done");
            Console.Read();
        }

        static void Test2()
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files/template_new.xlsx");
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, true))
            {
                string version = string.Empty;
                WorkbookPart wbPart = document.WorkbookPart;
                List<Sheet> sheets = wbPart.Workbook.Descendants<Sheet>().ToList();
                var versionSheet = wbPart.Workbook.Descendants<Sheet>().FirstOrDefault(c => c.Name == "data");
                WorksheetPart worksheetPart = (WorksheetPart)wbPart.GetPartById(versionSheet.Id);

                if (versionSheet == null)
                    throw new Exception("There must be Version sheet !");
                String[] cells = new string[] { "C36", "AK36", "AN36" };

                Row row = worksheetPart.Worksheet.Descendants<Row>().Where(r => r.RowIndex == 36).FirstOrDefault();
                row.AppendChild<Cell>(TestHelper.CreateCell(document, CellType.Number, "AN", 36, "200", null));
                for (var i = 0; i < cells.Length; i++)
                {
                    Cell theCell = worksheetPart.Worksheet.Descendants<Cell>().Where(c => c.CellReference.Value == cells[i]).FirstOrDefault();
                    string type = string.Empty;
                    if (theCell != null)
                    {
                        theCell.DataType = new EnumValue<CellValues>(CellValues.Number);
                        theCell.CellValue = new CellValue("10");
                    }
                }


                wbPart.Workbook.Save();
            }
        }

        //static void SetPivotSource(WorkbookPart wbPart, string sheetName, string lastReference)
        //{
        //    var charShitPart = wbPart.ChartsheetParts;
        //    foreach (PivotTableCacheDefinitionPart pivottablecachePart in pivottableCashes)
        //    {
        //        pivottablecachePart.PivotCacheDefinition.CacheSource.RemoveAllChildren();
        //        //设置Pivot tabla的数据源为A1:lastReference
        //        pivottablecachePart.PivotCacheDefinition.CacheSource.Append(new WorksheetSource()
        //        {
        //            Sheet = sheetName,
        //            Reference = new StringValue("A1:" + lastReference)
        //        });
        //    }
        //}

        //static void SetPivotSource(WorkbookPart wbPart, string sheetName, string lastReference)
        //{
        //    var pivottableCashes = wbPart.PivotTableCacheDefinitionParts;
        //    foreach (PivotTableCacheDefinitionPart pivottablecachePart in pivottableCashes)
        //    {
        //        pivottablecachePart.PivotCacheDefinition.CacheSource.RemoveAllChildren();
        //        //设置Pivot tabla的数据源为A1:lastReference
        //        pivottablecachePart.PivotCacheDefinition.CacheSource.Append(new WorksheetSource()
        //        {
        //            Sheet = sheetName,
        //            Reference = new StringValue("A1:" + lastReference)
        //        });
        //    }
        //}

        //static void Test1()
        //{
        //    var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "files/test1.xlsx");
        //    using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, false))
        //    {
        //        string version = string.Empty;
        //        WorkbookPart wbPart = document.WorkbookPart;
        //        List<Sheet> sheets = wbPart.Workbook.Descendants<Sheet>().ToList();
        //        var versionSheet = wbPart.Workbook.Descendants<Sheet>().FirstOrDefault(c => c.Name == "Sheet1");
        //        WorksheetPart worksheetPart = (WorksheetPart)wbPart.GetPartById(versionSheet.Id);

        //        if (versionSheet == null)
        //            throw new Exception("There must be Version sheet !");

        //        Cell theCell = worksheetPart.Worksheet.Descendants<Cell>().Where(c => c.CellReference.Value == "A2").FirstOrDefault();
        //        string type = string.Empty;
        //        if (theCell != null)
        //        {
        //            version = ExcelHelper.GetCellValue(wbPart, theCell);
        //            Console.WriteLine(version);
        //        }
        //        else
        //        {
        //            throw new Exception("Uploading file does not have version number!");
        //        }
        //    }
        //}
    }
}
