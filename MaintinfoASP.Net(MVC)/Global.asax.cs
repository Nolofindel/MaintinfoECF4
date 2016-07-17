using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using MaintinfoBll;

namespace MaintinfoASP.Net_MVC_
{
    public class MvcApplication : System.Web.HttpApplication
    {
        CatalogueManager initCat = new CatalogueManager();
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            //Chargement du catalogue avec les articles au demarage du code
            initCat.GenererCatalogue();
        }
    }
}
