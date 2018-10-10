using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestDic
    {
        public static void Test()
        {
            var dic = new Dictionary<Int32, String>()
            {
                { 3,"3"}, { 1,"1" },{5,"5" },{2,"2" },{ 4,"4"}
            };
            var orderDic = dic.OrderBy(it => it.Key).ToDictionary(it => it.Key, it => it.Value);
            var list = new List<String>();
            list.AddRange(orderDic.Values.ToArray());
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
