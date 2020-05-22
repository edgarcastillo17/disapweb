namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Picture", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Picture");
        }
    }
}
