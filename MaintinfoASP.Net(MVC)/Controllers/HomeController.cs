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
        
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Gestionnaire des piéces de maintenance informatique";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}