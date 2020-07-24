using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestByte
    {
        public static void Start()
        {
            ShowByteToString();
        }

        public static void ShowByteToString()
        {
            byte[] array = { 1, 2, 3, 4, 5, 6, 17, 19 };
            string s = string.Empty;
            foreach (byte b in array)
            {
                s += b.ToString();
                s += ",";
            }
            s = s.TrimEnd(',');
            Console.WriteLine(s);
        }
    }
}
