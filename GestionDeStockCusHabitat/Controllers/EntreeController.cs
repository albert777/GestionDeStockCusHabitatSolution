using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.Controllers
{
    /// <summary>
    /// L'attribut Authorize permet d'accéder a ces méthode uniquement si l'utilisateur est authentifié
    /// </summary>
    [Authorize]
    public class EntreeController : Controller
    {
        public ApplicationDbContext DbContext;

        public EntreeController()
        {
            DbContext = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            DbContext.Dispose();
        }

        /// <summary>
        /// Route affichant les entrées
        /// La vue est retourné avec les données de la table Entrées sous forme de liste
        /// </summary>
        /// <returns></returns>
        [Route("entree")]
        public ActionResult Entree()
        {
            var entrees = DbContext.Entrees.ToList();
            return View(entrees);
        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("entree/ajouter")]
        public ActionResult Ajouter()
        {
            return View();
        }

        public ActionResult Create(Article article)
        {
            //On instancie un objet Entree
            var entree = new Entree();

            //La catégorie de l'article est récuperer via la variable req qui est associé a une requetre
            var req = DbContext.Articles.Where(a => a.NomArticle == article.NomArticle).Select(a=>a.Categorie).Single();

            //On attribue les valeurs récuperer grace au formulaire, a l'objet entree
            entree.QteArticle = article.QteArticle;
            entree.NomArticle = article.NomArticle;
            entree.Categorie = req;
            entree.DateTime = DateTime.Now;

            //On incrémente la quantité de l'article avec la quantité de l'article concerné dans la table Articles
            var articleStocker =DbContext.Articles.Where(a => a.NomArticle == article.NomArticle).Select(a=>a).Single();
            articleStocker.QteArticle = articleStocker.QteArticle + article.QteArticle;

            DbContext.Entrees.Add(entree);
            DbContext.SaveChanges();

            return RedirectToAction("Entree","Entree");

        }
    }
}