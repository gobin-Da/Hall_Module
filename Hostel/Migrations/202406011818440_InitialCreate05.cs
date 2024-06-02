namespace Hostel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate05 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carosols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Caption = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carosols");
        }
    }
}
