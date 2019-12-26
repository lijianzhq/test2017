using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Test
{
    /// <summary>
    /// 测试反射
    /// </summary>
    public static class TestReflection
    {
        public static void Start()
        {
            Test1();
        }

        public static void Test1()
        {
            Console.WriteLine(typeof(String).GetMethod("ToUpper", new Type[] { }).DeclaringType.FullName);
        }
    }
}
