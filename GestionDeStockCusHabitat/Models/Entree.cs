using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeStockCusHabitat.Models
{
    public class Entree
    {
        public int Id { get; set; }
        [Required]
        public string NomArticle { get; set; }
        [Required]
        public int QteArticle { get; set; }
        [Required]
        public string Categorie { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

    }
}