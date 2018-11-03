using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSqlSugar.Models;

using SqlSugar;

namespace TestSqlSugar
{
    public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.Oracle,
                IsAutoCloseConnection = true
            });
        }
        public SqlSugarClient Db;
        public SimpleClient<Student> StudentDb { get { return new SimpleClient<Student>(Db); } }
        public SimpleClient<School> SchoolDb { get { return new SimpleClient<School>(Db); } }
    }
}
