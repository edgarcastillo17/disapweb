namespace Cafeteria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProduct : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Picture");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Picture", c => c.String());
        }
    }
}
