using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    public enum Test
    {
        Test1,Test2
    }

    class TestEnum
    {
        public static void Start()
        {
            Console.WriteLine(Test.Test1.ToString());
        }
    }
}
