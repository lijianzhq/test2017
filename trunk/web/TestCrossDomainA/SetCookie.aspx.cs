using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestCrossDomainA
{
    public partial class SetCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userid_a", "a_host");
            cookie.Domain = "a.com";
            HttpContext.Current.Response.AppendCookie(cookie);

            var cookie2 = new HttpCookie("userid_b", "b_host");
            cookie2.Domain = "b.com";
            HttpContext.Current.Response.AppendCookie(cookie);

            HttpContext.Current.Response.AddHeader("p3p", "CP=\"IDC DSP COR ADM DEVi TAIi PSA PSD IVAi IVDi CONi HIS OUR IND CNT\"");

            Response.Write("set cookie success!");
        }
    }
}