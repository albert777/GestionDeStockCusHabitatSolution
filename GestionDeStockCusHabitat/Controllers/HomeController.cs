using System.Web.Mvc;

namespace GestionDeStockCusHabitat.Controllers
{
    /// <summary>
    /// AllowAnonymous permet aux utilisateur de consulter la page sans etre authentifié
    /// </summary>
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application Crée en C# ASP.NET MVC par Jordan SANOGO";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pour me Contacter";

            return View();
        }
    }
}