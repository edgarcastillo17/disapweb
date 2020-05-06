namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSupplierPhone : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Suppliers", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Suppliers", "Phone", c => c.Int(nullable: false));
        }
    }
}
