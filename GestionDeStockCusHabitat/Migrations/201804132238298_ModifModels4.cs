namespace GestionDeStockCusHabitat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifModels4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sorties", "DateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sorties", "DateTime");
        }
    }
}
