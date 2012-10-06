using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TabExample.Models;

namespace TabExample.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult TabExample()
        {
            TabExample.Services.tabTextService serv = new TabExample.Services.tabTextService ();
            tabViewModel myModel = serv.getTabViewModel();

            return View(myModel);
        }

        public ActionResult TabAjaxExample()
        {
            return View();
        }

        public ActionResult getAjaxTab(int id)
        {
            string viewName = string.Empty;

            TabExample.Services.tabTextService serv = new TabExample.Services.tabTextService();
            tabViewModel myModel = serv.getTabViewModel();

            switch (id)
            {
                case 1:
                    viewName = "_tab1";
                    break;
                case 2:
                    viewName = "_tab2";
                    break;
                case 3:
                    viewName = "_tab3";
                    break;
                case 4:
                    viewName = "_error";
                    break;
            }

            System.Threading.Thread.Sleep(1000);   

            return PartialView(viewName, myModel);
        }
    }
}
