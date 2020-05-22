namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductName", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Image", c => c.Binary(nullable: false));
            AlterColumn("dbo.Purchases", "ClientName", c => c.String(nullable: false));
            AlterColumn("dbo.Purchases", "Comment", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Purchases", "Comment", c => c.String());
            AlterColumn("dbo.Purchases", "ClientName", c => c.String());
            AlterColumn("dbo.Products", "Image", c => c.Binary());
            AlterColumn("dbo.Products", "Type", c => c.String());
            AlterColumn("dbo.Products", "ProductName", c => c.String());
        }
    }
}
