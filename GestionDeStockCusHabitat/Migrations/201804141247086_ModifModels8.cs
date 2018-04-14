namespace GestionDeStockCusHabitat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels8 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.Sorties", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Sorties", new[] { "Article_Id" });
            DropIndex("dbo.Sorties", new[] { "Client_Id" });
            AddColumn("dbo.Sorties", "NomArticle", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "QteArticle", c => c.Int(nullable: false));
            AddColumn("dbo.Sorties", "ClientId", c => c.Int(nullable: false));
            DropColumn("dbo.Sorties", "Article_Id");
            DropColumn("dbo.Sorties", "Client_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sorties", "Client_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Sorties", "Article_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Sorties", "ClientId");
            DropColumn("dbo.Sorties", "QteArticle");
            DropColumn("dbo.Sorties", "Categorie");
            DropColumn("dbo.Sorties", "NomArticle");
            CreateIndex("dbo.Sorties", "Client_Id");
            CreateIndex("dbo.Sorties", "Article_Id");
            AddForeignKey("dbo.Sorties", "Client_Id", "dbo.Clients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
        }
    }
}
