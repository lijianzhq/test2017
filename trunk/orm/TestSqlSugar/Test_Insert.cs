using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;
using TestSqlSugar.Models;

namespace TestSqlSugar
{
    class Test_Insert
    {
        public static void Start()
        {
            /*插入*/
            var data = new Student() { Name = "jack" };
            DBContext2.Db.Insertable(data).ExecuteCommand();
        }
    }
}
