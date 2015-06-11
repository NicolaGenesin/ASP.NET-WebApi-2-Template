using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiApplication
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //default routing template MUST be disabled
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            //use custom routes
            config.MapHttpAttributeRoutes();
            config.EnableSystemDiagnosticsTracing();
        }
    }
}
