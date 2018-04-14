namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            AlterColumn("dbo.Entrees", "Article_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id", cascadeDelete: true);
            DropColumn("dbo.Entrees", "InventaireId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Entrees", "InventaireId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            AlterColumn("dbo.Entrees", "Article_Id", c => c.Int());
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id");
        }
    }
}
