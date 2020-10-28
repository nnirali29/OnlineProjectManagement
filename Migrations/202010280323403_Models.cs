namespace OnlineProjectManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Models : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        userName = c.String(),
                        password = c.Decimal(nullable: false, precision: 18, scale: 2),
                        active = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Phone = c.String(),
                        role = c.String(),
                        Optout = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Payid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PayAmmount = c.String(),
                        ID = c.Int(nullable: false),
                        PaymentMethod = c.String(),
                        Status = c.String(),
                        Paymentdate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Payid);
            
            CreateTable(
                "dbo.ProjectDocs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pid = c.Int(nullable: false),
                        Did = c.String(),
                        Docname = c.String(),
                        active = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectName = c.String(),
                        Description = c.String(),
                        Duedate = c.DateTime(nullable: false),
                        priority = c.String(),
                        Status = c.String(),
                        isActive = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TimeLogs",
                c => new
                    {
                        GUID = c.Int(nullable: false, identity: true),
                        comment = c.String(),
                        endate = c.String(),
                        startdate = c.DateTime(nullable: false),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.GUID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logins", "Id", "dbo.users");
            DropIndex("dbo.Logins", new[] { "Id" });
            DropTable("dbo.TimeLogs");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectDocs");
            DropTable("dbo.Payments");
            DropTable("dbo.users");
            DropTable("dbo.Logins");
        }
    }
}
