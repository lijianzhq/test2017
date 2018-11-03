using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSqlSugar.Models;

using SqlSugar;

namespace TestSqlSugar
{
    public class DBContext2
    {
        public static SqlSugarClient Db;
        static DBContext2()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString,
                DbType = DbType.SqlServer,//设置数据库类型
                IsAutoCloseConnection = true,//自动释放数据务，如何存在事务，在事务结束后释放
                InitKeyType = InitKeyType.Attribute //从实体特性中读取主键自增列信息
            });

            //用来打印Sql方便你调式    
            Db.Aop.OnLogExecuting = (sql, pars) =>
            {
                Console.WriteLine();
                Console.WriteLine(sql + "\r\n" +
                Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            };
        }
    }
}
