using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    class Class1
    {
        public static void ArgumentNotNull<T>(T arg, string name) where T : class
        {
            //Microsoft.VisualStudio.TextTemplating36E00E433782F90FE584C183913817268260DA58F66E29B69A9BF2A206FA2D775CBB3B8B4DF1CC06CDAC9BB1FAFE82AA91442C02854B2EA60F2532A90408C69D.GeneratedTextTransformation
            if (arg == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
