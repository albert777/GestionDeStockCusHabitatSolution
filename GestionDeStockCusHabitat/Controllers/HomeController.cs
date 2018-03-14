using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionDeStockCusHabitat.Controllers
{
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