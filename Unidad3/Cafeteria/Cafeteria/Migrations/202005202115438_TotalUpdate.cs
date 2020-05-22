namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Purchases", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
