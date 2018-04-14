using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.ViewModel
{
    public class SortieViewModel
    {
        [Required(ErrorMessage = "Nom de l'article requis")][Display(Name = "Nom de l'article")]
        public String NomArticle { get; set; }

        public int QteArticle { get; set; }
        public String Categorie { get; set; }
        public DateTime DateTime { get; set; }
        public int ClientId { get; set; }
        public SelectList ArticleList { get; set; }
        [Required(ErrorMessage = "Nom du client requis")][Display(Name = "Client")]
        public SelectList ClientList { get; set; }
        public List<Sortie> Sorties { get; set; }
    }
}