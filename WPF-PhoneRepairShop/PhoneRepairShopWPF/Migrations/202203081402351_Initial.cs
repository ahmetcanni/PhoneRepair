namespace WPFPhoneRepairShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeightCentimeter = c.Int(nullable: false),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        City = c.String(),
                        MaxCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneModel = c.Int(nullable: false),
                        PhoneColor = c.Int(nullable: false),
                        PhoneCapacity = c.Int(nullable: false),
                        Brand = c.String(),
                        HourRate = c.Double(nullable: false),
                        DayRate = c.Double(nullable: false),
                        Phone_Id = c.Int(),
                        Store_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phones", t => t.Phone_Id)
                .ForeignKey("dbo.Stores", t => t.Store_Id)
                .Index(t => t.Phone_Id)
                .Index(t => t.Store_Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        Customer_Id = c.Int(),
                        DropoffStore_Id = c.Int(),
                        Phone_Id = c.Int(),
                        PickupStore_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.Customer_Id)
                .ForeignKey("dbo.Stores", t => t.DropoffStore_Id)
                .ForeignKey("dbo.Phones", t => t.Phone_Id)
                .ForeignKey("dbo.Stores", t => t.PickupStore_Id)
                .Index(t => t.Customer_Id)
                .Index(t => t.DropoffStore_Id)
                .Index(t => t.Phone_Id)
                .Index(t => t.PickupStore_Id);
            
            CreateTable(
                "dbo.StoreCustomers",
                c => new
                    {
                        Store_Id = c.Int(nullable: false),
                        Customer_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Store_Id, t.Customer_Id })
                .ForeignKey("dbo.Stores", t => t.Store_Id, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_Id, cascadeDelete: true)
                .Index(t => t.Store_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "PickupStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "Phone_Id", "dbo.Phones");
            DropForeignKey("dbo.Reservations", "DropoffStore_Id", "dbo.Stores");
            DropForeignKey("dbo.Reservations", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.Phones", "Store_Id", "dbo.Stores");
            DropForeignKey("dbo.Phones", "Phone_Id", "dbo.Phones");
            DropForeignKey("dbo.StoreCustomers", "Customer_Id", "dbo.Customers");
            DropForeignKey("dbo.StoreCustomers", "Store_Id", "dbo.Stores");
            DropIndex("dbo.StoreCustomers", new[] { "Customer_Id" });
            DropIndex("dbo.StoreCustomers", new[] { "Store_Id" });
            DropIndex("dbo.Reservations", new[] { "PickupStore_Id" });
            DropIndex("dbo.Reservations", new[] { "Phone_Id" });
            DropIndex("dbo.Reservations", new[] { "DropoffStore_Id" });
            DropIndex("dbo.Reservations", new[] { "Customer_Id" });
            DropIndex("dbo.Phones", new[] { "Store_Id" });
            DropIndex("dbo.Phones", new[] { "Phone_Id" });
            DropTable("dbo.StoreCustomers");
            DropTable("dbo.Reservations");
            DropTable("dbo.Phones");
            DropTable("dbo.Stores");
            DropTable("dbo.Customers");
        }
    }
}
