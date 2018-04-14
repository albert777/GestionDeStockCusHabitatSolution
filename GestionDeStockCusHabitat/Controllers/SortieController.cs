using System;
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
            using (var dbcontext = new ApplicationDbContext())
            {
                var model = new SortieViewModel {Sorties = dbcontext.Sorties.ToList()};
                return View(model);
            }

        }

        /// <summary>
        /// Route retournant la vue du formulaire de sortie
        /// </summary>
        /// <returns></returns>
        [Route("sortie/sortiearticle")]
        public ActionResult SortieArticle()
        {
            var dbContext = new ApplicationDbContext();
            var model = new SortieViewModel
            {
                ArticleList = new SelectList(dbContext.Articles.Select(c => c.NomArticle), "NomArticle"),
                ClientList = new SelectList(dbContext.Clients.Select(c => new {c.Nom, c.Prenom}))
            };
            
            return View(model);
        }

        public ActionResult SortirUnArticle(Sortie sortie)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                sortie.Categorie = dbContext.Articles
                    .Where(a => a.NomArticle == sortie.NomArticle)
                    .Select(a => a.NomArticle).Single();
                sortie.DateTime = DateTime.Now;
                dbContext.Sorties.Add(sortie);
                var articleMisAJour = dbContext.Articles.Where(a => a.NomArticle == sortie.NomArticle).Select(a => a).Single();
                articleMisAJour.QteArticle = articleMisAJour.QteArticle - sortie.QteArticle;

                dbContext.SaveChanges();
                return RedirectToAction("Entree","Entree");
            }
        }
    }
}