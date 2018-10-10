using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestCrossDomainA
{
    public partial class ReadCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userid_a = Request.Cookies["userid_a"] == null ? "" : Request.Cookies["userid_a"].Value.ToString();
            Response.Write($"userid_a:{userid_a}");

            var userid_b = Request.Cookies["userid_b"] == null ? "" : Request.Cookies["userid_b"].Value.ToString();
            Response.Write($"userid_b:{userid_b}");

        }
    }
}