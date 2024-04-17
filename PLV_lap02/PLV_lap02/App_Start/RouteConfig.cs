using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PLV_lap02
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
            name: "Play music",
            url: "Am-nhac/Nhac",
            defaults: new { controller = "PLV_products", action = "PlayMusic" }
            );
            routes.MapRoute(
            name: "Show Product",
            url: "Am-nhac/Danh-Sach-Am-Nhac",
            defaults: new { controller = "PLV_products", action = "Musiclist" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
