using System.ComponentModel.DataAnnotations;

namespace GestionDeStockCusHabitat.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Email { get; set; }
    }
}