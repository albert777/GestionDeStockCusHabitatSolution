﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeStockCusHabitat.Models
{
    public class Entree
    {
        public int Id { get; set; }
        [Required][Display(Name = "Nom de l'article")]
        public string NomArticle { get; set; }
        [Required][Display(Name = "Quantité")]
        public int QteArticle { get; set; }
        [Required][Display(Name = "Catégorie")]
        public string Categorie { get; set; }
        [Required][Display(Name = "Date d'ajout")]
        public DateTime DateTime { get; set; }

    }
}