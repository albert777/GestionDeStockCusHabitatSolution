using System;
using System.Linq;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;
using GestionDeStockCusHabitat.ViewModel;

namespace GestionDeStockCusHabitat.Controllers
{
    /// <summary>
    /// L'attribut Authorize permet d'accéder a ces méthode uniquement si l'utilisateur est authentifié
    /// </summary>
    [Authorize]
    public class EntreeController : Controller
    {

        /// <summary>
        /// Route affichant les entrées
        /// La vue est retourné avec les données de la table Entrées sous forme de liste
        /// </summary>
        /// <returns></returns>
        [Route("entree")]
        public ActionResult Entree()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var model = new EntreeViewModel();
                model.Entrees = dbContext.Entrees.ToList();
                return View(model);
            }

        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("entree/ajouter")]
        public ActionResult Ajouter()
        {
            var dbContext = new ApplicationDbContext();
            var model = new EntreeViewModel
            {
                ArticleList = new SelectList(dbContext.Articles.Select(c => c.NomArticle), "NomArticle")
            };
            return View(model);
        }

        public ActionResult Create(Entree entree)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                entree.Categorie = dbContext.Articles.Where(a => a.NomArticle == entree.NomArticle)
                    .Select(a => a.NomArticle).Single();
                entree.DateTime = DateTime.Now;
                dbContext.Entrees.Add(entree);

                var articleMisAJour = dbContext.Articles.Where(a => a.NomArticle == entree.NomArticle).Select(a => a).Single();
                articleMisAJour.QteArticle = articleMisAJour.QteArticle + entree.QteArticle;

                dbContext.SaveChanges();
                return RedirectToAction("Entree","Entree");
            }

        }
    }
}