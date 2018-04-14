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
    public class ArticleController : Controller
    {

        [Route("article")]
        public ActionResult Article()
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                var model = new ArticleViewModel();
                model.Articles = dbcontext.Articles.ToList();
                return View(model);
            }
        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("article/ajouter")]
        public ActionResult Ajouter()
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                var model = new ArticleViewModel();
                model.Articles = dbcontext.Articles.ToList();
                return View(model);
            }
        }

        /// <summary>
        /// Récupère les valeurs entré dans le formulaire de la vue AjouterEntree et les rajoute dans la table Entrees
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Article article)
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                dbcontext.Articles.Add(article);
                dbcontext.SaveChanges();
            }

            return RedirectToAction("Article","Article");
        }

    }
}