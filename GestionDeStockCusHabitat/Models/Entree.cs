using System;
using System.ComponentModel.DataAnnotations;

namespace GestionDeStockCusHabitat.Models
{
    public class Entree
    {
        public int Id { get; set; }
        [Required][Display(Name = "Nom de l'article")]
        public String NomArticle { get; set; }
        [Required][Display(Name = "Catégorie")]
        public String Categorie { get; set; }
        [Required][Display(Name = "Quantité")]
        public int QteArticle { get; set; }
        [Required][Display(Name = "Date d'ajout")]
        public DateTime DateTime { get; set; }
    }
}