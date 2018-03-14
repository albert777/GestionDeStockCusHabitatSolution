using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.Controllers
{
    public class InventaireController : Controller
    {
        // GET: Inventaire
        private ApplicationDbContext _dbContext;

        public InventaireController()
        {
            _dbContext = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _dbContext.Dispose();
        }

        [Route("inventaire")]
        public ActionResult InventaireResult()
        {
            var inventaires = _dbContext.Inventaires.ToList();

            return View(inventaires);
        }

    }
}