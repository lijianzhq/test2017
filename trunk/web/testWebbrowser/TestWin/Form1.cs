using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            wb_browser.Navigate("http://localhost:9050/testWebbrowser/index.html");
        }

        private void wb_browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            IHTMLDocument2 vDocument = (IHTMLDocument2)wb_browser.Document.DomDocument;
            vDocument.parentWindow.execScript("function confirm(str){return true;}", "javascript"); //弹出确认
            vDocument.parentWindow.execScript("function alert(str){return true;}", "javaScript");//弹出提示
            vDocument.parentWindow.execScript("setPageDetails()", "javascript"); //弹出确认
        }
    }
}
