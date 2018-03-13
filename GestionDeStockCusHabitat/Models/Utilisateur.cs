using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeStockCusHabitat.Models
{
    public class Utilisateur
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string MotDePasse { get; set; }
        [Required]
        public string Email { get; set; }
    }
}