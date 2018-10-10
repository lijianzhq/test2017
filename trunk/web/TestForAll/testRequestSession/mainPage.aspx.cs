using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForAll.testRequestSession
{
    public partial class mainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var value = Request.Params["testParam"];
            if (Session["userName"] != null)
            {
                //Response.Write(value);
                Response.Write(Session["userName"]);
            }
            else
            {
                Response.Write("未登录");
            }
            Response.End();
        }
    }
}