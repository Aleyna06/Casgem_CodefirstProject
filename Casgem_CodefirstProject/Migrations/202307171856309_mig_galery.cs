namespace Casgem_CodefirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_galery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Galeries",
                c => new
                    {
                        GaleryID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GaleryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Galeries");
        }
    }
}
