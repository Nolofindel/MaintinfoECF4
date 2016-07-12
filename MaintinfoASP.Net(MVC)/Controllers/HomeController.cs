using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MaintinfoBll;

namespace MaintinfoASP.Net_MVC_.Controllers
{
    
    public class HomeController : Controller
    {
        CatalogueManager initCat = new CatalogueManager();
        
        public ActionResult Index()
        {
            initCat.GenererCatalogue();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}