using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class TestString
    {
        public static void Start()
        {
            TestSubString();
        }

        public static void TestSubString()
        {
            Console.WriteLine("abc".Substring(1));
            Console.WriteLine("abc".Substring(2));
        }
    }
}
