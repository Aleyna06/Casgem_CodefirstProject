 namespace Casgem_CodefirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_odev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutMes",
                c => new
                    {
                        AboutMeID = c.Int(nullable: false, identity: true),
                        Title1 = c.String(),
                        Description1 = c.String(),
                        ImageUrl1 = c.String(),
                        Title2 = c.String(),
                        Description2 = c.String(),
                        ImageUrl2 = c.String(),
                    })
                .PrimaryKey(t => t.AboutMeID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutMes");
        }
    }
}
