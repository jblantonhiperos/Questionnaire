using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Routing;
using Microsoft.Owin.Security.OAuth;
using Models;
using Newtonsoft.Json.Serialization;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
