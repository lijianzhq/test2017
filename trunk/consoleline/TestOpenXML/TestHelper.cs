using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TestOpenXML
{

    public class Mapping
    {
        public string SourceField { get; set; }
        public string DestinationCellHeader { get; set; }
        public string DestinationReference { get; set; }
        public CellType CellType { get; set; }
    }
    public enum CellType
    {
        Text,
        Number,
        Date,
        Boolean
    }

    class TestHelper
    {
        public List<Mapping> GetRawMappings(string fileName, string sheetName)
        {
            List<Mapping> mappings = new List<Mapping>();
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(fileName, true))
            {
                WorkbookPart workbookPart = document.WorkbookPart;
                Sheet dataSheet = workbookPart.Workbook.Descendants<Sheet>().Where(s => string.Compare(s.Name, sheetName, true) == 0).FirstOrDefault();//sheetName为你要导入数据的工作表名称
                if (dataSheet != null)
                {
                    WorksheetPart worksheetPart = workbookPart.GetPartById(dataSheet.Id.Value) as WorksheetPart;
                    var headerRow = worksheetPart.Worksheet.GetFirstChild<SheetData>().Elements<Row>().
                                            FirstOrDefault(c => c.RowIndex == 1);//读取首行
                    mappings = headerRow.Elements<Cell>().Select(c => new Mapping()
                    {
                        DestinationReference = c.CellReference.Value.Replace("1", ""),
                        DestinationCellHeader = ExcelHelper.GetCellValue(workbookPart, c)
                    }).ToList();
                }
            }
            return null;
        }

        private static Row CreateContentRow(SpreadsheetDocument document, int index, System.Data.DataRow dr, List<Mapping> mappings, Nullable<uint> dateStyleID)
        {
            //Create the new row.
            Row row = new Row();
            row.RowIndex = (UInt32)index;
            //First cell is a text cell, so create it and append it.
            //Cell firstCell = CreateTextCell(referenceHeaders[0],index);
            //r.AppendChild(firstCell);
            //Create the cells that contain the data.
            foreach (var mapping in mappings)
            {
                Cell cell = null;
                string source = string.Empty;
                if (!string.IsNullOrEmpty(mapping.SourceField))
                    source = dr[mapping.SourceField].ToString();
                cell = CreateCell(document, mapping.CellType, mapping.DestinationReference, index, source, dateStyleID);
                row.AppendChild(cell);
            }
            return row;
        }


        public static Cell CreateCell(SpreadsheetDocument document, CellType type, string header, int index, string text, Nullable<uint> dateStyleID)
        {
            Cell cell = new Cell();
            cell.CellReference = header + index;

            CellValue value = null;
            if (type == CellType.Text)
            {
                //int stringIndex = ExcelHelper.AppendOrGetSharedStringItem(text, document);
                //stringIndex.ToString()
                value = new CellValue(text);
                cell.DataType = new EnumValue<CellValues>(CellValues.String);
            }
            if (type == CellType.Date)
            {
                if (!string.IsNullOrEmpty(text))
                {
                    DateTime dt = DateTime.Parse(text);
                    value = new CellValue(dt.ToOADate().ToString());
                }
                cell.StyleIndex = dateStyleID;
                cell.DataType = new EnumValue<CellValues>(CellValues.Number); //new EnumValue<CellValues>(CellValues.Date);
            }
            if (type == CellType.Number)
            {
                cell.DataType = new EnumValue<CellValues>(CellValues.Number);
                value = new CellValue(text);
            }

            cell.CellValue = value;
            //cell.AppendChild(value);
            return cell;
        }

        //      Stylesheet styleSheet = workbookPart.WorkbookStylesPart.Stylesheet;
        //      var dateStyleId = ExcelHelper.CreateCellFormat(styleSheet, null, null, UInt32Value.FromUInt32(14));
        //      //var  references = headerRow.Elements<Cell>().Select(c => c.CellReference.Value.Replace("1", "")).ToList();
        //      var i = 1;
        //foreach (System.Data.DataRow row in data.Rows)
        //{
        //   Row contentRow = CreateContentRow(document, ((int)maxRowIndex) + i++, row, cols, dateStyleId);
        //      //Append new row to sheet data.
        //      sheetData.AppendChild(contentRow);
        //}
    }
}
