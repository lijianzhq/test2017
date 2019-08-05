using System;
using System.Collections;
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
            //Test4();
            Test5();
        }

        /// <summary>
        /// 测试遍历指针
        /// </summary>
        public static void Test5()
        {
            var data = new Func<IEnumerable>(() =>
            {
                return new List<Int32>() { 0 };
            }).Invoke();
            var enumerator = data.GetEnumerator();
            var moveNext = enumerator?.MoveNext();
            Console.WriteLine(enumerator.Current);
        }

        /// <summary>
        /// 测试keypari不能为空的现象
        /// </summary>
        public static void Test4()
        {
            var dic = new Dictionary<String, Int32>();
            var keyPair = dic.SingleOrDefault(it => it.Key == "aaa");
            Console.WriteLine(keyPair.Value);
        }

        /// <summary>
        /// 测试hasset是否可以加入相同的值
        /// </summary>
        public static void Test3(List<Parent> parentList)
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
