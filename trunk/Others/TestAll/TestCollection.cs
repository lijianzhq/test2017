using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAll
{
    class TestCollection
    {
        public static void Start()
        {
            var set = new HashSet<String>();
            set.Add("1");
            set.Add("1");
            Console.WriteLine(set.Count);
        }

        /// <summary>
        /// 测试逆变和协变
        /// </summary>
        public static void Test1(List<Parent> parentList)
        {
            //Test2(new List<Parent>());
        }

        /// <summary>
        /// 测试逆变和协变
        /// </summary>
        /// <param name="childList"></param>
        public static void Test2(List<Child> childList)
        {
            //Test1(new List<Child>());
        }
    }
}
