namespace CaseySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigrato : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Summary = c.String(nullable: false),
                        Description = c.String(),
                        Link = c.String(),
                        Github = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Projects");
        }
    }
}
