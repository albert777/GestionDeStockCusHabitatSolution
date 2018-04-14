using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GestionDeStockCusHabitat.Models;

namespace GestionDeStockCusHabitat.ViewModel
{
    public class ClientViewModel
    {
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Email { get; set; }

        public List<Client> Clients { get; set; }

    }
}