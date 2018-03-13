namespace GestionDeStockCusHabitat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateUtilisateurs : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Utilisateurs (Nom, Prenom, Login, MotDePasse, Email) VALUES ('SANOGO', 'Jordan', 'jordan', 'jordan', 'jordan.sanogo@cushabitat.fr')");
            Sql("INSERT INTO Utilisateurs (Nom, Prenom, Login, MotDePasse, Email) VALUES ('JAHIC', 'Edin', 'edin', 'edin', 'edin.jahic@polehabitatstrasbourg.fr')");
        }
        
        public override void Down()
        {
        }
    }
}
