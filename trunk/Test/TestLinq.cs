using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestLinq
    {
        public static void Test()
        {
            var keyName = "zhq";
            var keyNameChars = keyName.ToCharArray().Select(it => { Console.WriteLine(it); return it.ToString(); });
            Console.WriteLine("keyNameCharsLength:");
            Console.WriteLine(keyNameChars.Count());
            Console.WriteLine(keyNameChars.Count());
        }
    }
}
