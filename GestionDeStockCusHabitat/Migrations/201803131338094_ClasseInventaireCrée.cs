namespace GestionDeStockCusHabitat.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class ClasseInventaireCrée : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomArticle = c.String(nullable: false),
                        QteArticle = c.Int(nullable: false),
                        Categorie = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Inventaires");
        }
    }
}
