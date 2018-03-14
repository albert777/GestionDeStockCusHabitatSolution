using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
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
        public ViewResult UtilisateurResult()
        {
            var utilisateurs = _context.Utilisateurs.ToList();

            return View(utilisateurs);
        }

        public ActionResult New()
        {
            return View();
        }

    }
}