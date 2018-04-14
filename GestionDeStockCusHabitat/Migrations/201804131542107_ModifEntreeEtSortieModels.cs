namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifEntreeEtSortieModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entrees", "InventaireId", c => c.Int(nullable: false));
            AddColumn("dbo.Sorties", "Inventaire_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Entrees", "InventaireId");
            CreateIndex("dbo.Sorties", "Inventaire_Id");
            AddForeignKey("dbo.Entrees", "InventaireId", "dbo.Inventaires", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sorties", "Inventaire_Id", "dbo.Inventaires", "Id", cascadeDelete: true);
            DropColumn("dbo.Entrees", "NomArticle");
            DropColumn("dbo.Entrees", "Categorie");
            DropColumn("dbo.Sorties", "NomArticle");
            DropColumn("dbo.Sorties", "Categorie");
            DropTable("dbo.Utilisateurs");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false),
                        Prenom = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        MotDePasse = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Sorties", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "NomArticle", c => c.String(nullable: false));
            AddColumn("dbo.Entrees", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Entrees", "NomArticle", c => c.String(nullable: false));
            DropForeignKey("dbo.Sorties", "Inventaire_Id", "dbo.Inventaires");
            DropForeignKey("dbo.Entrees", "InventaireId", "dbo.Inventaires");
            DropIndex("dbo.Sorties", new[] { "Inventaire_Id" });
            DropIndex("dbo.Entrees", new[] { "InventaireId" });
            DropColumn("dbo.Sorties", "Inventaire_Id");
            DropColumn("dbo.Entrees", "InventaireId");
        }
    }
}
