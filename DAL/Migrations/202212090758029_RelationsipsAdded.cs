namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationsipsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tkey = c.Int(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                        AdminID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Admins", t => t.AdminID, cascadeDelete: true)
                .Index(t => t.AdminID);
            
            CreateTable(
                "dbo.CusTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tkey = c.Int(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                        ResID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.ResID, cascadeDelete: true)
                .Index(t => t.ResID);
            
            CreateTable(
                "dbo.ResTokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tkey = c.Int(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                        ResID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.ResID, cascadeDelete: true)
                .Index(t => t.ResID);
            
            AlterColumn("dbo.Admins", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Admins", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Admins", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Bookings", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Contact", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Menus", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Menus", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Payments", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Ratings", "CusRating", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Restaurants", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Contact", c => c.String(nullable: false));
            AlterColumn("dbo.Restaurants", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Reviews", "CusReview", c => c.String(nullable: false));
            CreateIndex("dbo.Bookings", "CusID");
            CreateIndex("dbo.Bookings", "ResID");
            CreateIndex("dbo.Payments", "CusID");
            CreateIndex("dbo.Payments", "ResID");
            CreateIndex("dbo.Menus", "ResID");
            CreateIndex("dbo.Ratings", "CusID");
            CreateIndex("dbo.Ratings", "ResID");
            CreateIndex("dbo.Reviews", "CusID");
            CreateIndex("dbo.Reviews", "ResID");
            AddForeignKey("dbo.Payments", "CusID", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Menus", "ResID", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ratings", "CusID", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ratings", "ResID", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "CusID", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "ResID", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Payments", "ResID", "dbo.Restaurants", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bookings", "CusID", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Bookings", "ResID", "dbo.Restaurants", "Id", cascadeDelete: true);
            DropTable("dbo.Tokens");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tokens",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tkey = c.Int(nullable: false),
                        Creation = c.DateTime(nullable: false),
                        Expiration = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Bookings", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Bookings", "CusID", "dbo.Customers");
            DropForeignKey("dbo.Payments", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Reviews", "CusID", "dbo.Customers");
            DropForeignKey("dbo.ResTokens", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Ratings", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Ratings", "CusID", "dbo.Customers");
            DropForeignKey("dbo.Menus", "ResID", "dbo.Restaurants");
            DropForeignKey("dbo.Payments", "CusID", "dbo.Customers");
            DropForeignKey("dbo.CusTokens", "ResID", "dbo.Customers");
            DropForeignKey("dbo.AdminTokens", "AdminID", "dbo.Admins");
            DropIndex("dbo.Reviews", new[] { "ResID" });
            DropIndex("dbo.Reviews", new[] { "CusID" });
            DropIndex("dbo.ResTokens", new[] { "ResID" });
            DropIndex("dbo.Ratings", new[] { "ResID" });
            DropIndex("dbo.Ratings", new[] { "CusID" });
            DropIndex("dbo.Menus", new[] { "ResID" });
            DropIndex("dbo.Payments", new[] { "ResID" });
            DropIndex("dbo.Payments", new[] { "CusID" });
            DropIndex("dbo.CusTokens", new[] { "ResID" });
            DropIndex("dbo.Bookings", new[] { "ResID" });
            DropIndex("dbo.Bookings", new[] { "CusID" });
            DropIndex("dbo.AdminTokens", new[] { "AdminID" });
            AlterColumn("dbo.Reviews", "CusReview", c => c.String());
            AlterColumn("dbo.Restaurants", "Type", c => c.String());
            AlterColumn("dbo.Restaurants", "Contact", c => c.String());
            AlterColumn("dbo.Restaurants", "Address", c => c.String());
            AlterColumn("dbo.Restaurants", "Password", c => c.String());
            AlterColumn("dbo.Restaurants", "Email", c => c.String());
            AlterColumn("dbo.Restaurants", "Name", c => c.String());
            AlterColumn("dbo.Ratings", "CusRating", c => c.String());
            AlterColumn("dbo.Payments", "Status", c => c.String());
            AlterColumn("dbo.Menus", "Type", c => c.String());
            AlterColumn("dbo.Menus", "Name", c => c.String());
            AlterColumn("dbo.Customers", "Type", c => c.String());
            AlterColumn("dbo.Customers", "Contact", c => c.String());
            AlterColumn("dbo.Customers", "Password", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Bookings", "Status", c => c.String());
            AlterColumn("dbo.Admins", "Type", c => c.String());
            AlterColumn("dbo.Admins", "Password", c => c.String());
            AlterColumn("dbo.Admins", "Email", c => c.String());
            AlterColumn("dbo.Admins", "Name", c => c.String());
            DropTable("dbo.ResTokens");
            DropTable("dbo.CusTokens");
            DropTable("dbo.AdminTokens");
        }
    }
}
