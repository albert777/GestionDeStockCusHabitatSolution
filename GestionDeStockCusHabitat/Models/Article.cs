using System.ComponentModel.DataAnnotations;

namespace GestionDeStockCusHabitat.Models
{
    public class Article
    {
        public int Id { get; set; }
        [Required][Display(Name = "Nom de l'article")]
        public string NomArticle { get; set; }
        [Required][Display(Name = "Quantité")]
        public int QteArticle { get; set; }
        [Required][Display(Name = "Catégorie")]
        public string Categorie { get; set; }
    }
}