using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SqlSugar;
using TestSqlSugar.Models;

namespace TestSqlSugar
{
    class Test_Delete
    {
        public static void Start()
        {
            /*删除*/
            DBContext2.SqlServerDb.Deleteable<StudentModel>(1).ExecuteCommand();
        }
    }
}
