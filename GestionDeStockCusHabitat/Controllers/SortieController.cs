using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;
using GestionDeStockCusHabitat.ViewModel;

namespace GestionDeStockCusHabitat.Controllers
{
    [Authorize]
    public class SortieController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [Route("sortie")]
        public ActionResult Sortie()
        {
            var model = new SortieViewModel();
            model.Sorties = new List<Sortie>();
            return View(model);
        }

        /// <summary>
        /// Route retournant la vue du formulaire de sortie
        /// </summary>
        /// <returns></returns>
        [Route("sortie/sortiearticle")]
        public ActionResult SortieArticle()
        {
            return View();
        }

        public ActionResult SortirUnArticle(Sortie sortie)
        {
            return RedirectToAction("Sortie","Sortie");

        }
    }
}