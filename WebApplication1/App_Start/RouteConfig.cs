using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace WebApplication1
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.EnableFriendlyUrls();

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { action = "Index", id = UrlParameter.Optional }
                );    
        }
    }
}
