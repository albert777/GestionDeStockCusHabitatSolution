using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.ViewModel
{
    public class EntreeViewModel
    {
        public string NomArticle { get; set; }
        [Required][Display(Name = "Quantité")]
        public int QteArticle { get; set; }
        [Required][Display(Name = "Catégorie")]
        public string Categorie { get; set; }

        public SelectList ArticleList { get; set; }
        public List<Entree> Entrees { get; set; }
    }
}