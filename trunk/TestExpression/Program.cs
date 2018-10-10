using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestExpression
{
    public class Persion
    {
        public String Name { get; set; }
        public String password { get; set; }
        public DateTime? Birthday { get; set; }
        public Int16? age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<Boolean>> exp1 = () => (1 + 2) == (3 + 4);
            Expression<Func<Persion, Boolean>> exp2 = (it) => it.Name == "lijian" && 100 == it.age;

            Persion persion = new Persion() { };

            Expression<Func<Persion, Boolean>> exp3 = (it) => it.Name == persion.Name && it.age == 100;
            Expression<Func<Persion, Boolean>> exp4 = (it) => it.Name == persion.Name && 100 == it.age;
            Expression<Func<Persion, Boolean>> exp5 = (it) => persion.Name == it.Name && ("aaa" + persion.password == it.password) && (100 == it.age || "" == it.password);
            Expression<Func<Persion, Boolean>> exp6 = (it) => true;
            Expression<Func<Persion, dynamic>> exp7 = (it) => new { it.age, it.password };
            ExpressionToSql expToSql = new ExpressionToSql();

            Console.WriteLine(exp1.ToString());
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(exp2.ToString());
            //Console.WriteLine(expToSql.GetSql<Persion>(exp2));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(exp3.ToString());
            //Console.WriteLine(expToSql.GetSql<Persion>(exp3));
            //Console.WriteLine(Environment.NewLine);
            //Console.WriteLine(exp4.ToString());
            //Console.WriteLine(expToSql.GetSql<Persion>(exp4));
            //Console.WriteLine(Environment.NewLine);
            Console.Read();
        }
    }
}
