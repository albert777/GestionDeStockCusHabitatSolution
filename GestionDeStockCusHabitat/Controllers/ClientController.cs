using System.Linq;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;
using GestionDeStockCusHabitat.ViewModel;

namespace GestionDeStockCusHabitat.Controllers
{
    [Authorize]
    public class ClientController : Controller
    {

        [Route("client")]
        public ActionResult Client()
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                var model = new ClientViewModel();
                model.Clients = dbcontext.Clients.ToList();
                return View(model);
            }
        }

        /// <summary>
        /// Route retournant la vue du formulaire d'entrée
        /// </summary>
        /// <returns></returns>
        [Route("client/ajouter")]
        public ActionResult Ajouter()
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                var model = new ClientViewModel();
                model.Clients = dbcontext.Clients.ToList();
                return View(model);
            }
        }

        /// <summary>
        /// Récupère les valeurs entré dans le formulaire de la vue AjouterEntree et les rajoute dans la table Entrees
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(Client client)
        {
            using (var dbcontext = new ApplicationDbContext())
            {
                dbcontext.Clients.Add(client);
                dbcontext.SaveChanges();
            }
            return RedirectToAction("Client","Client");
        }

    }
}