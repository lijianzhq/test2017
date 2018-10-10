using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{
    public class TestHttpUtility
    {
        public static void Test()
        {
            Console.WriteLine("&middot;");
            Console.WriteLine(HttpUtility.HtmlDecode("&middot;"));
        }
    }
}
