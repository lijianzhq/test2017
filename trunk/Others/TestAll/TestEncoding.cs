using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    class TestEncoding
    {
        public static void Start()
        {
            String String1 = "";
            Console.WriteLine(Encoding.UTF8.GetBytes(String1));
            String String2 = null;
            Console.WriteLine(Encoding.UTF8.GetBytes(String2));
        }
    }
}
