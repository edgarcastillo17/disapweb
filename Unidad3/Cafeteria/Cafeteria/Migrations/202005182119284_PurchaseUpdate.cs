namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Comment", c => c.String());
            AddColumn("dbo.Purchases", "Status", c => c.String());
            DropColumn("dbo.Purchases", "ProductName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Purchases", "ProductName", c => c.String());
            DropColumn("dbo.Purchases", "Status");
            DropColumn("dbo.Purchases", "Comment");
        }
    }
}
