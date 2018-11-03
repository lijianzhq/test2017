using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJSON
{
    public class ParentObj
    {
        public String GetName()
        {
            return "parentobj";
        }
    }

    public class ChildObj : ParentObj
    {
        public new String GetName()
        {
            return "childObj";
        }
    }
}
