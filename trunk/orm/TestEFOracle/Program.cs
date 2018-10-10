using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEFOracle
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
            Console.Read();
        }

        static void Test()
        {
            using (MQCSBUS_My db = new MQCSBUS_My())
            {
                Console.WriteLine(db.T_EAP_SYS_USER.Count());
            }
        }
    }
}
