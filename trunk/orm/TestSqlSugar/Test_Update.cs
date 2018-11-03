using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;
using TestSqlSugar.Models;

namespace TestSqlSugar
{
    class Test_Update
    {
        public static void Start()
        {
            /*更新*/
            var data2 = new Student() { Id = 1, Name = "jack" };
            Console.WriteLine(DBContext2.Db.Updateable(data2).ExecuteCommand());
        }
    }
}
