namespace Casgem_CodefirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation_guide_socialmedia : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "GuideID", c => c.Int(nullable: false));
            CreateIndex("dbo.SocialMedias", "GuideID"); //u
            AddForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides", "GuideID", cascadeDelete: true);
            //update database yaparsak açlışacak işlemler 
        }

        public override void Down()
        {
            DropForeignKey("dbo.SocialMedias", "GuideID", "dbo.Guides");
            DropIndex("dbo.SocialMedias", new[] { "GuideID" });
            DropColumn("dbo.SocialMedias", "GuideID");
            //İşlemlerden vazgeçersek 
        }
    }
}
