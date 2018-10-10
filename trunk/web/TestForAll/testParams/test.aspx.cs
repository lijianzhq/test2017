using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Management;

namespace TestForAll.testParams
{
    public partial class test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (String o in Request.ServerVariables)
            {
                Response.Write(o + "=" + Request.ServerVariables[o] + "<br>");
            }
            string stringMAC = ""; string stringIP = "";
            ManagementClass MC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection MOC = MC.GetInstances();
            Response.Write("<br><br><br>");
            foreach (ManagementObject MO in MOC)
            {
                if ((bool)MO["IPEnabled"] == true)
                {
                    stringMAC += MO["MACAddress"].ToString(); //获取网卡的地址
                    string[] IPAddresses = (string[])MO["IPAddress"]; //获取本地的IP地址
                    if (IPAddresses.Length > 0) stringIP = IPAddresses[0]; Response.Write(stringMAC + "/" + stringIP);
                }
            }
        }
    }
}