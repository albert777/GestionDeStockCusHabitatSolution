using System.Web.Mvc;
using System.Web.Routing;

namespace GestionDeStockCusHabitat
{
    /// <summary>
    /// routes.MapMvcAttributeRoutes(); permet de créer les route directement au-dessus des méthodes des controlleurs
    /// </summary>
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
