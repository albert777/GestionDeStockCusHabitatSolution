using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {
        // GET: Inventaire
        private ApplicationDbContext _dbContext;

        public ClientController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        [Route("client")]
        public ActionResult Client()
        {
            var article = _dbContext.Clients.ToList();

            return View(article);
        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("client/ajouter")]
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
        public ActionResult Create(Client client)
        {

            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();

            return RedirectToAction("Client","Client");

        }

    }
}