namespace Flooringsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Customer_Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        CustomerEmail = c.String(maxLength: 50),
                        ContactNumber = c.String(nullable: false, maxLength: 11),
                        RequestedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customer");
        }
    }
}
