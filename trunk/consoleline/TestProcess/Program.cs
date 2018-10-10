using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestThreadPriority.Start();
            Console.WriteLine(typeof(Program).Assembly.GetName());
            Console.WriteLine(typeof(Program).Assembly.GetName().Name);
            var asmName = typeof(Program).Assembly.FullName;
            Console.WriteLine(asmName.Substring(0, asmName.IndexOf(",")).Trim());
            Console.Read();
        }
    }
}
