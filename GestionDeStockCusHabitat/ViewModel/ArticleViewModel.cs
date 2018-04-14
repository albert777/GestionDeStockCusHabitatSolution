using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.ViewModel
{
    public class ArticleViewModel
    {
        [Required][Display(Name = "Nom de l'article")]
        public string NomArticle { get; set; }
        [Required][Display(Name = "Quantité")]
        public int QteArticle { get; set; }
        [Required][Display(Name = "Catégorie")]
        public string Categorie { get; set; }

        public List<Article> Articles { get; set; }
    }
}