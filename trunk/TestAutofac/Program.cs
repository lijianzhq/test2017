using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autofac;

namespace TestAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            TestExpressionRegistrations.Start();
            Console.Read();
        }
    }

    public abstract class Animal
    {
        protected String _name = String.Empty;
        public Animal(String name)
        {
            _name = name;
        }
        public abstract void ShowName();
    }

    public class Cat : Animal
    {
        public Cat(String name) : base(name)
        { }
        public override void ShowName()
        {
            Console.WriteLine("i'm a cat, my name is {0}!", _name);
        }
    }
}
