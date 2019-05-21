namespace CaseySite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPhotoToProject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Photo");
        }
    }
}
