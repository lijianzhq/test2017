using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestString
{
    class TestRegex
    {
        public static void Test()
        {
            //String text = "<html><a>dddd<a>";
            //Console.WriteLine(CleanString(text));
            //text = "大风打算范德萨affafdsa";
            //Console.WriteLine(CleanString(text));
            //text = "<a></a>11aa<a>fdsafdsafda</a>测试";
            //Console.WriteLine(CleanString(text));


            //Console.WriteLine(Regex.Replace("<img> abc </img>", @"<img> (?<str>.*?) </img>", "[图片]${str}"));

            Console.WriteLine(GetValue("2010央视主打热播剧《血色沉香》全34集[国语字幕]", "《", "》"));
        }

        public static String CleanString(String input)
        {
            if (String.IsNullOrWhiteSpace(input)) return input;
            Regex reg = new Regex(@"<a\b[^>]*>([\s\S]*?)</a>");
            return reg.Replace(input, "");
        }

        public static string GetValue(string str, string s, string e)
        {
            Regex rg = new Regex("(?<=(" + s + "))[.\\s\\S]*?(?=(" + e + "))", RegexOptions.Multiline | RegexOptions.Singleline);
            return rg.Match(str).Value;
        }
    }
}
