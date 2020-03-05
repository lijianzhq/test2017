using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAll
{
    class TestInterlocked
    {
        public static void Start()
        {
            Int32 i = 0;
            Console.WriteLine(Interlocked.Decrement(ref i));
            Console.WriteLine(i);
        }
    }
}
