using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Parent
    {
        public String Name { get; set; }
    }

    class Child : Parent
    {
        public Int32 Age { get; set; }
    }
}
