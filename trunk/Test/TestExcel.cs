using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using DreamCube.Foundation.Office;

namespace Test
{
    class TestExcel
    {
        public static void Start()
        {
            var tb_excel = MyExcel.GetSheetData(@"C:\Users\ljmacx64\Desktop\test.xlsx");
            if (tb_excel != null && tb_excel.Rows.Count > 0)
            {
                foreach (DataRow row in tb_excel.Rows)
                {
                    foreach (DataColumn col in tb_excel.Columns)
                        Console.Write(row[col] + "\t");
                    Console.WriteLine();
                }
            }
        }
    }
}
