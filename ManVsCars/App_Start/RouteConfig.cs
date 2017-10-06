using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing;

namespace ManVsCars
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            DefaultInlineConstraintResolver constraintResolver = new DefaultInlineConstraintResolver();

            constraintResolver.ConstraintMap.Add("magicWords", typeof(Constrainter));

            routes.MapMvcAttributeRoutes(constraintResolver);

            routes.MapRoute(
                name: "Default",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
