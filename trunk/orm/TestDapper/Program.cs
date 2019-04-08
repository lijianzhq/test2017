using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

using Dapper;

namespace TestDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            //Test2();
            Test3();

            Console.WriteLine("done");
            Console.Read();
        }

        static void Test()
        {
            using (var conn = GetConnection())
            {
                var role = conn.Query<T_EAP_SYS_ROLE>("select * from T_EAP_SYS_ROLE where role_code='WORKSHOP123'").FirstOrDefault();
                Console.WriteLine($"{role?.ROLE_CODE},{role?.ROLE_NAME}");

                var insertSQL = $"insert into T_EAP_SYS_ROLE(ROLE_ID,ROLE_CODE,ROLE_NAME,ORG_ID) values('{Guid.NewGuid()}',:ROLE_CODE,:ROLE_NAME,:ORG_ID)";
                role.ROLE_CODE += "_test";
                role.ROLE_NAME += "_test";
                conn.Execute(insertSQL, role);
            }
        }

        static void Test2()
        {
            using (var conn = GetConnection())
            {
                var role = conn.Query<Student>("select * from STUDENT").FirstOrDefault();
                Console.WriteLine($"{role?.Name},{role?.TestCount}");
            }
        }

        static void Test3()
        {
            using (var conn = GetConnection())
            {
                var cmd = conn.CreateCommand() as OracleCommand;
                cmd.CommandText = "select * from student";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn as OracleConnection;

                var adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                var table = dataSet.Tables[0];
                Console.WriteLine(table.Rows.Count);
            }
        }

        static DbConnection GetConnection()
        {
            //return new OracleConnection("DATA SOURCE=10.16.40.171:1521/apsweb.midea.com;PASSWORD=aps;PERSIST SECURITY INFO=True;USER ID=aps");
            return new OracleConnection("Data Source = (DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.16.40.171)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = apsweb.midea.com))); User Id = aps; Password = aps");
        }
    }
}
