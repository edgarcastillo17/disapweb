namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletePicture : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Picture", c => c.String());
        }
    }
}
