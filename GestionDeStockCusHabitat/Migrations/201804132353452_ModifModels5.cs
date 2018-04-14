namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sorties", "Article_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Sorties", "Article_Id");
            AddForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
            DropColumn("dbo.Sorties", "NomArticle");
            DropColumn("dbo.Sorties", "QteArticle");
            DropColumn("dbo.Sorties", "Categorie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sorties", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Sorties", "QteArticle", c => c.Int(nullable: false));
            AddColumn("dbo.Sorties", "NomArticle", c => c.String(nullable: false));
            DropForeignKey("dbo.Sorties", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Sorties", new[] { "Article_Id" });
            DropColumn("dbo.Sorties", "Article_Id");
        }
    }
}
