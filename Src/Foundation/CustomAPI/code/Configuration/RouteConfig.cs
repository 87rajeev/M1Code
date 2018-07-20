using System.Web.Mvc;
using System.Web.Routing;

namespace M1CP.Foundation.CustomAPI.Configuration
{
    public class RouteConfig
    {
        /// <summary>
        /// Registers the routes described by routes.
        /// </summary>
        /// <param name="routes">The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Used for web services
            RouteTable.Routes.MapMvcAttributeRoutes();
        }
    }
}