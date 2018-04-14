using System;
using System.ComponentModel.DataAnnotations;

namespace GestionDeStockCusHabitat.Models
{
    public class Sortie
    {
        public int Id { get; set; }
        [Required][Display(Name = "Nom de l'article")]
        public Article Article { get; set; }
        public DateTime DateTime { get; set; }
        [Required][Display(Name = "Client")]
        public Client Client { get; set; }
    }
}