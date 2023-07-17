namespace Casgem_CodefirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_final : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.ContactSocials",
                c => new
                    {
                        ContactSocialID = c.Int(nullable: false, identity: true),
                        ContactSocialName = c.String(),
                        ContactSocialURL = c.String(),
                        ContactSocialIcon = c.String(),
                    })
                .PrimaryKey(t => t.ContactSocialID);
            
            CreateTable(
                "dbo.Explores",
                c => new
                    {
                        ExploreID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ExploreID);
            
            CreateTable(
                "dbo.FooterGaleries",
                c => new
                    {
                        FooterGaleryID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FooterGaleryID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        PlaceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PlaceID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.ServiceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
            DropTable("dbo.Places");
            DropTable("dbo.FooterGaleries");
            DropTable("dbo.Explores");
            DropTable("dbo.ContactSocials");
            DropTable("dbo.Categories");
        }
    }
}
