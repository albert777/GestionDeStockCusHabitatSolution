namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            DropIndex("dbo.Sorties", new[] { "Article_Id" });
            AddColumn("dbo.Entrees", "NomArticle", c => c.String(nullable: false));
            AddColumn("dbo.Entrees", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "NomArticle", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "Categorie", c => c.String(nullable: false));
            DropColumn("dbo.Entrees", "Article_Id");
            DropColumn("dbo.Sorties", "DateTime");
            DropColumn("dbo.Sorties", "Article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sorties", "Article_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Sorties", "DateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Entrees", "Article_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Sorties", "Categorie");
            DropColumn("dbo.Sorties", "NomArticle");
            DropColumn("dbo.Entrees", "Categorie");
            DropColumn("dbo.Entrees", "NomArticle");
            CreateIndex("dbo.Sorties", "Article_Id");
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
        }
    }
}
