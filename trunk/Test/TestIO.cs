using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test
{
    class TestIO
    {
        public static void Start()
        {
            TestCombine();
        }

        public static void TestCombine()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(Path.Combine(path, "/ab/c"));
        }
    }
}
