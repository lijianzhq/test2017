using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TestAll
{
    class TestDataTable
    {
        public static void Start()
        {
            TestDelete();
        }

        /// <summary>
        /// 测试遍历指针
        /// </summary>
        public static void TestDelete()
        {
            var table = new DataTable();
            table.Columns.Add("test");
            table.Rows.Add(1);
            table.Rows.Add(2);
            table.Rows.Add(3);
            table.Rows.Add(4);
            table.Rows.Add(5);
            table.Rows.Add(6);
            table.Rows.Add(7);
            table.Rows.Add(8);
            Console.WriteLine(table.Rows.Count);
            for (var i = table.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(table.Rows[i][0]) % 2 == 0)
                {
                    table.Rows.RemoveAt(i);
                }
            }
            Console.WriteLine(table.Rows.Count);
        }
    }
}
