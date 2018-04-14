using System.Linq;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.Controllers
{
    /// <summary>
    /// L'attribut Authorize permet d'accéder a ces méthode uniquement si l'utilisateur est authentifié
    /// </summary>
    [Authorize]
    public class ArticleController : Controller
    {
        // GET: Inventaire
        private ApplicationDbContext _dbContext;

        public ArticleController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        [Route("article")]
        public ActionResult Article()
        {
            var article = _dbContext.Articles.ToList();

            return View(article);
        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("article/ajouter")]
        public ActionResult Ajouter()
        {
            return View();
        }

        /// <summary>
        /// Récupère les valeurs entré dans le formulaire de la vue AjouterEntree et les rajoute dans la table Entrees
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Article article)
        {

            _dbContext.Articles.Add(article);
            _dbContext.SaveChanges();

            return RedirectToAction("Article","Article");

        }

    }
}