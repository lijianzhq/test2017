using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestForAll.testParams
{
    public partial class test2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var serverName = Request.ServerVariables.Get("Server_Name").ToString();
            Response.Write($"Server_Name：{serverName}<br>");
            var serverIP = Request.ServerVariables.Get("Local_Addr").ToString();
            Response.Write($"Local_Addr：{serverIP}<br>");
        }
    }
}