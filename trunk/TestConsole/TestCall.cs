using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;

namespace TestConsole
{
    class TestCall
    {
        /// <summary>
        /// 直接调用
        /// </summary>
        public static void DoCallByFunName()
        {
            //TestDLL.TestHelper.WriteFileInD();
        }

        /// <summary>
        /// 反射调用
        /// </summary>
        public static void DoCallByReflection()
        {
            //while (true)
            //{
            //var helperType = Assembly.Load("TestDLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null").GetType("TestDLL.TestHelper");
            //var method = helperType.GetMethod("WriteFileInD");
            //method.Invoke(null, null);
            //Thread.Sleep(3000);
            //}
        }

        /// <summary>
        /// 隔离调用
        /// </summary>
        public static void DoCallByRunDomain()
        {
            //while (true)
            //{
            var appLoader = new RunDomain.AssemblyLoader("myLoader");
            var testDLL = appLoader.Load("TestDLL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");
            var result = testDLL.ExecStaticMethod("TestDLL.TestHelper", "SayHello", new Object[] { "jianl" });
            testDLL.ExecStaticMethod("TestDLL.TestHelper", "WriteFileInD", new Object[] { "jianl" });
            testDLL.ExecStaticMethod("TestDLL.TestHelper", "WriteFileInD");
            Console.WriteLine(result);
            appLoader.Dispose();
            //    Thread.Sleep(3000);
            //}
        }
    }
}
