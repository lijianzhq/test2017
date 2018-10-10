using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using mshtml;

namespace TestWinForm
{
    public partial class TestWebbrowser : Form
    {
        public TestWebbrowser()
        {
            InitializeComponent();
        }

        private void TestWebbrowser_Load(object sender, EventArgs e)
        {
            var htmlFile = "file:///" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "testWebbrowser.html");
            wb.Navigate(htmlFile);
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            String url = e.Url.ToString();
            IHTMLDocument2 vDocument = (IHTMLDocument2)wb.Document.DomDocument;
            vDocument.parentWindow.execScript("function confirm(str){return true;} ", "javascript"); //弹出确认
            vDocument.parentWindow.execScript("function alert(str){return true;} ", "javaScript");//弹出提示
            if (url.IndexOf("testWebbrowser.html") != -1)
            {
                var doc = wb.Document;
                //HtmlElement head = doc.GetElementsByTagName("head")[0];
                var head = doc.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = doc.CreateElement("script");
                mshtml.IHTMLScriptElement element = (mshtml.IHTMLScriptElement)scriptEl.DomElement;
                string alertBlocker = "window.alert = function () { }";
                element.text = alertBlocker;
                head.AppendChild(scriptEl);
            }
            else if (url.IndexOf("testWebbrowser_frame.html") != -1)
            {
                vDocument = (IHTMLDocument2)wb.Document.Window.Frames["testFrame"].Document.DomDocument;
                vDocument.parentWindow.execScript("function confirm(str){return true;} ", "javascript"); //弹出确认
                vDocument.parentWindow.execScript("function alert(str){return true;} ", "javaScript");//弹出提示
                //var doc = wb.Document.Window.Frames["testFrame"].Document;
                ////HtmlElement head = doc.GetElementsByTagName("head")[0];
                //var head = doc.GetElementsByTagName("head")[0];
                //HtmlElement scriptEl = doc.CreateElement("script");
                //mshtml.IHTMLScriptElement element = (mshtml.IHTMLScriptElement)scriptEl.DomElement;
                //string alertBlocker = "window.alert = function () { }";
                //element.text = alertBlocker;
                //head.AppendChild(scriptEl);
            }
            wb.ScriptErrorsSuppressed = true;
        }

        private void wb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            String url = e.Url.ToString();
            IHTMLDocument2 vDocument = (IHTMLDocument2)wb.Document.DomDocument;
            vDocument.parentWindow.execScript("function confirm(str){return true;} ", "javascript"); //弹出确认
            vDocument.parentWindow.execScript("function alert(str){return true;} ", "javaScript");//弹出提示
            if (url.IndexOf("testWebbrowser.html") != -1)
            {
                var doc = wb.Document;
                //HtmlElement head = doc.GetElementsByTagName("head")[0];
                var head = doc.GetElementsByTagName("head")[0];
                HtmlElement scriptEl = doc.CreateElement("script");
                mshtml.IHTMLScriptElement element = (mshtml.IHTMLScriptElement)scriptEl.DomElement;
                string alertBlocker = "window.alert = function () { }";
                element.text = alertBlocker;
                head.AppendChild(scriptEl);
            }
            else if (url.IndexOf("testWebbrowser_frame.html") != -1)
            {
                vDocument = (IHTMLDocument2)wb.Document.Window.Frames["testFrame"].Document.DomDocument;
                vDocument.parentWindow.execScript("function confirm(str){return true;} ", "javascript"); //弹出确认
                vDocument.parentWindow.execScript("function alert(str){return true;} ", "javaScript");//弹出提示
                //var doc = wb.Document.Window.Frames["testFrame"].Document;
                ////HtmlElement head = doc.GetElementsByTagName("head")[0];
                //var head = doc.GetElementsByTagName("head")[0];
                //HtmlElement scriptEl = doc.CreateElement("script");
                //mshtml.IHTMLScriptElement element = (mshtml.IHTMLScriptElement)scriptEl.DomElement;
                //string alertBlocker = "window.alert = function () { }";
                //element.text = alertBlocker;
                //head.AppendChild(scriptEl);
            }
            wb.ScriptErrorsSuppressed = true;
        }
    }
}
