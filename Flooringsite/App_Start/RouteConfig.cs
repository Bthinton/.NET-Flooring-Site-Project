using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flooringsite
{
    using System.Web.Mvc;
    using System.Web.Routing;


    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}