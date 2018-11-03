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
            var school = new School() { Name = "文武学校" };
            school = DBContext2.Db.Insertable(school).ExecuteReturnEntity();
            Console.WriteLine(school.Id);

            /*插入*/
            var data = new Student() { Name = "jack", SchoolId = school.Id };
            Console.WriteLine(DBContext2.Db.Insertable(data).ExecuteCommand());
        }
    }
}
