using System;
using System.Web.Mvc;
using System.Text;

namespace TestEFCodeFirst2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            //var sb = new StringBuilder();
            //using (var db = new Models.DB())
            //{
            //    foreach (var item in db.Donators)
            //    {
            //        sb.AppendFormat("<div>{0}</div>", String.Format("{0} donate ￥{1}", item.Name, item.Amount));
            //    }
            //}
            //ViewData["infos"] = sb.ToString();
            return View();
        }
    }
}