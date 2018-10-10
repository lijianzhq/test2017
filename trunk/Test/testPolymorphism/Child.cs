using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.testPolymorphism
{
    class Child : Parent
    {
        public Child()
        { }

        public override void Init()
        {
            Console.WriteLine("child");
            //base.Init();
        }
    }
}
