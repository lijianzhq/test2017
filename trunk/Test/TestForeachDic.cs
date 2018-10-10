using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class TestForeachDic
    {
        public static void Test1()
        {
            Dictionary<String, String> dic = new Dictionary<string, string>()
            {
                { "1","1"},
                { "2","2"},
            };
            foreach (var Key in dic.Keys.ToArray())
            {
                dic[Key] = dic[Key] + dic[Key];
            }
            foreach (var item in dic)
            {
                Console.WriteLine(dic[item.Key]);
            }
        }
    }
}
