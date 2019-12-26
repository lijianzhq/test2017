using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Test
{
    /// <summary>
    /// 表达式树的测试
    /// </summary>
    public static class TestExpression
    {
        public static void Start()
        {
            //Test1();
            //Test2();
            Test3();
        }

        public static void Test1()
        {
            // Add the following directive to your file:
            // using System.Linq.Expressions;  

            // This expression represents a call to an instance method without arguments.
            Expression callExpr = Expression.Call(
                Expression.Constant("sample string"), typeof(String).GetMethod("ToUpper", new Type[] { }));

            // Print out the expression.
            Console.WriteLine(callExpr.ToString());

            // The following statement first creates an expression tree,
            // then compiles it, and then executes it. 
            var method = Expression.Lambda<Func<String>>(callExpr).Compile();
            Console.WriteLine(method());

            // This code example produces the following output:
            //
            // "sample string".ToUpper
            // SAMPLE STRING
        }

        public static void Test2()
        {
            Expression<Func<int, int, bool>> largeSumTest =
                        (num1, num2) => (num1 + num2) > 1000;

            // Create an InvocationExpression that represents applying
            // the arguments '539' and '281' to the lambda expression 'largeSumTest'.
            var invocationExpression =
                System.Linq.Expressions.Expression.Invoke(
                    largeSumTest,
                    System.Linq.Expressions.Expression.Constant(539),
                    System.Linq.Expressions.Expression.Constant(281));

            Console.WriteLine(invocationExpression.ToString());
        }

        public static void Test3()
        {
            var func = new Func<Int32>(() => { return 0; });

            // Create an InvocationExpression that represents applying
            // the arguments '539' and '281' to the lambda expression 'largeSumTest'.
            var invocationExpression =
                System.Linq.Expressions.Expression.Invoke(Expression.Constant(func));

            Console.WriteLine(invocationExpression.ToString());
        }

        public static void Test4()
        {
            var func = new Func<Int32>(() => { return 0; });

            // Create an InvocationExpression that represents applying
            // the arguments '539' and '281' to the lambda expression 'largeSumTest'.
            var invocationExpression =
                System.Linq.Expressions.Expression.Invoke(Expression.Constant(func));

            Console.WriteLine(invocationExpression.ToString());
        }
    }
}
