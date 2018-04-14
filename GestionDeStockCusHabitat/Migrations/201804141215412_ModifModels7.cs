namespace GestionDeStockCusHabitat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels7 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            AddColumn("dbo.Entrees", "NomArticle", c => c.String(nullable: false));
            AddColumn("dbo.Entrees", "Categorie", c => c.String(nullable: false));
            DropColumn("dbo.Entrees", "Article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entrees", "Article_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Entrees", "Categorie");
            DropColumn("dbo.Entrees", "NomArticle");
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
        }
    }
}
