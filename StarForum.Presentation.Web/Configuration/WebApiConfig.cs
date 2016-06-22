using System.Web.Http;
using StarForum.Presentation.Web.Framework;

namespace StarForum.Presentation.Web.Configuration
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{action}/{id}",
                defaults: new { id = RouteParameter.Optional, controller = "ForumApi", action = "GetLatest" }
            );

            config.Formatters.Add(new ApiJsonFormatter());
        }
    }
}
