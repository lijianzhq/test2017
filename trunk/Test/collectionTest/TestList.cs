using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.collectionTest
{
    class TestList
    {
        public static void Test()
        {
            Test2();
        }

        public static void Test1()
        {
            var listA = new List<String> { "1", "2", "3" };
            var listB = new List<String> { "2", "3", "4" };
            var listC = listA.Except(listB).ToList();
            var listD = listB.Except(listA).ToList();
            listC.ForEach((o) =>
            {
                Console.WriteLine(o);
            });
            listD.ForEach((o) =>
            {
                Console.WriteLine(o);
            });
        }

        public static void Test2()
        {
            var data = new List<String>();
            var data2 = new List<String>();
            data.AddRange(data2);
        }
    }
}
