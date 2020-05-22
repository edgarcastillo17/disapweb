namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteTotalReturn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "Total");
        }
    }
}
