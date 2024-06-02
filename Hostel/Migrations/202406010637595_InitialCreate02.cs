namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Applies", "StudentRegistration", c => c.String(nullable: false));
            DropColumn("dbo.Applies", "StudentImage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Applies", "StudentImage", c => c.String(nullable: false));
            DropColumn("dbo.Applies", "StudentRegistration");
        }
    }
}
