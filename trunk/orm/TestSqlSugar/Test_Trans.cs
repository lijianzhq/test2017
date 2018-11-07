using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSqlSugar
{
    class Test_Trans
    {
        public static void Start()
        {
            //事务锁测试
            //sqlserver的测试
            Test1(DBContext2.SqlServerDb);
            //oracle的测试
            //Test1(DBContext2.OracleDb);

            //Test2_InsertData(DBContext2.OracleDb);
        }

        public static void Test2_InsertData(SqlSugar.SqlSugarClient client)
        {
            try
            {
                var stu = new Student()
                {
                    Id = 96010,
                    Name = "lijian"
                };
                client.Insertable<Student>(stu)
                       .InsertColumns(it => new { it.Id, it.Name, })
                       .ExecuteCommand();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Test1(SqlSugar.SqlSugarClient client)
        {
            try
            {
                client.Ado.BeginTran(System.Data.IsolationLevel.Snapshot);
                var stu = new Student()
                {
                    Id = 95010,
                    Name = "lijian22222"
                };
                client.Updateable<Student>(stu)
                    .UpdateColumns(it => new { it.Name, it.Id })
                    .WhereColumns(it => it.Id)
                    .ExecuteCommand();

                var aa = stu;
                client.Ado.CommitTran();
            }
            catch (Exception ex)
            {
                client.Ado.RollbackTran();
            }
        }
    }
}
