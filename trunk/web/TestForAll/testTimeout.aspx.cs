using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForAll
{
    public partial class testTimeout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000 * 60 * 30);
            Response.Write("{'success':'true','message':'123'}");
            Response.End();
        }
    }
}