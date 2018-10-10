using System;
using System.IO;

namespace TestDLL
{
    public static class TestHelper
    {
        public static void WriteFileInD()
        {
            File.AppendAllText(@"d:\aa.txt", "   aaa   ");
        }

        public static String SayHello(String userName)
        {
            return String.Format("Hello,{0}!!!", userName);
        }

        public static void WriteFileInD(String data)
        {
            File.AppendAllText(@"d:\aa.txt", data);
        }
    }
}
