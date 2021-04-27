namespace DALLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Inventories", newName: "Inventory");
            AlterColumn("dbo.Inventory", "name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Inventory", "qty_stock", c => c.Int(nullable: false));
            AlterColumn("dbo.Inventory", "vendor", c => c.String(nullable: false));
            AlterColumn("dbo.Inventory", "password", c => c.String(nullable: false));
            AlterColumn("dbo.Inventory", "comparepassword", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventory", "comparepassword", c => c.String());
            AlterColumn("dbo.Inventory", "password", c => c.String());
            AlterColumn("dbo.Inventory", "vendor", c => c.String());
            AlterColumn("dbo.Inventory", "qty_stock", c => c.Int());
            AlterColumn("dbo.Inventory", "name", c => c.String());
            RenameTable(name: "dbo.Inventory", newName: "Inventories");
        }
    }
}
