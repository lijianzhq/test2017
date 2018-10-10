using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OracleClient;

using Dapper;

namespace TestDapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();

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

        static DbConnection GetConnection()
        {
            return new OracleConnection("DATA SOURCE=172.26.136.162:1521/KFMQCS;PASSWORD=MQCSBUS;PERSIST SECURITY INFO=True;USER ID=MQCSBUS");
        }
    }
}
