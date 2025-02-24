namespace InventoryManager.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InventoryAppDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Garments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Quantity = c.Int(nullable: false),
                        Size = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Garments");
        }
    }
}
