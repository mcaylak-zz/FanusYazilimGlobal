namespace FanusYazilim.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advertisements",
                c => new
                    {
                        AdvertisementID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(maxLength: 100),
                        Owner = c.String(maxLength: 72),
                    })
                .PrimaryKey(t => t.AdvertisementID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 64),
                        DisplayLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Contents",
                c => new
                    {
                        ContentID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DisplayLength = c.Int(nullable: false),
                        PrintLength = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContentID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 72),
                        Password = c.String(),
                        SecurityGuid = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contents", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Contents", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Contents");
            DropTable("dbo.Categories");
            DropTable("dbo.Advertisements");
        }
    }
}
