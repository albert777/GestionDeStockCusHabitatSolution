namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Entrees", "Article_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
            DropColumn("dbo.Entrees", "NomArticle");
            DropColumn("dbo.Entrees", "Categorie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entrees", "Categorie", c => c.String(nullable: false));
            AddColumn("dbo.Entrees", "NomArticle", c => c.String(nullable: false));
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            DropColumn("dbo.Entrees", "Article_Id");
        }
    }
}
