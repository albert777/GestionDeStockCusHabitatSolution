using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.ViewModel
{
    public class SortieViewModel
    {
        [Required(ErrorMessage = "Nom de l'article requis")][Display(Name = "Nom de l'article")]
        public Article Article { get; set; }
        public DateTime DateTime { get; set; }
        [Required(ErrorMessage = "Nom du client requis")][Display(Name = "Client")]
        public Client Client { get; set; }

        public List<Sortie> Sorties { get; set; }
    }
}