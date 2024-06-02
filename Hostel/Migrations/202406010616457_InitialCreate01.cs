namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate01 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Hostels", newName: "HostelClasses");
            CreateTable(
                "dbo.Applies",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 12),
                        City = c.String(nullable: false),
                        Area = c.String(nullable: false),
                        Road = c.String(nullable: false),
                        StudentImage = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applies");
            RenameTable(name: "dbo.HostelClasses", newName: "Hostels");
        }
    }
}
