using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;
using Microsoft.Ajax.Utilities;


namespace GestionDeStockCusHabitat.Controllers
{
    public class UtilisateursController : Controller
    {
        private ApplicationDbContext _context;

        public UtilisateursController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("utilisateurs")]
        public ViewResult Index()
        {
            var utilisateurs = _context.Utilisateurs.ToList();

            return View(utilisateurs);
        }

        [Route("utilisateurs/{id}")]
        public ActionResult Details(int id)
        {
            var utilisateur = _context.Utilisateurs.SingleOrDefault(c => c.Id == id);

            if (utilisateur == null)
                return HttpNotFound();
            return View(utilisateur);
        }

    }
}