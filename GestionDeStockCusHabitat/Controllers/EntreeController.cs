using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.Controllers
{
    public class EntreeController : Controller
    {
        public ApplicationDbContext _DbContext;

        public EntreeController()
        {
            _DbContext = new ApplicationDbContext();
            
        }

        protected override void Dispose(bool disposing)
        {
            _DbContext.Dispose();
        }

        [Route("entree")]
        public ActionResult Entree()
        {
            var entrees = _DbContext.Entrees.ToList();
            return View(entrees);
        }

        [Route("entree/ajouter")]
        public ActionResult AjouterEntree()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Entree entree)
        {

            _DbContext.Entrees.Add(entree);
            _DbContext.SaveChanges();

            return RedirectToAction("Entree","Entree");

        }
    }
}