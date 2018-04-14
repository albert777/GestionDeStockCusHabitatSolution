namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Inventaires", newName: "Articles");
            DropForeignKey("dbo.Entrees", "InventaireId", "dbo.Inventaires");
            DropIndex("dbo.Entrees", new[] { "InventaireId" });
            RenameColumn(table: "dbo.Sorties", name: "Inventaire_Id", newName: "Article_Id");
            RenameIndex(table: "dbo.Sorties", name: "IX_Inventaire_Id", newName: "IX_Article_Id");
            AddColumn("dbo.Entrees", "Article_Id", c => c.Int());
            CreateIndex("dbo.Entrees", "Article_Id");
            AddForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrees", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Entrees", new[] { "Article_Id" });
            DropColumn("dbo.Entrees", "Article_Id");
            RenameIndex(table: "dbo.Sorties", name: "IX_Article_Id", newName: "IX_Inventaire_Id");
            RenameColumn(table: "dbo.Sorties", name: "Article_Id", newName: "Inventaire_Id");
            CreateIndex("dbo.Entrees", "InventaireId");
            AddForeignKey("dbo.Entrees", "InventaireId", "dbo.Inventaires", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Articles", newName: "Inventaires");
        }
    }
}
