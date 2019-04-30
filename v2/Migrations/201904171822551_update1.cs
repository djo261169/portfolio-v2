namespace v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Story", c => c.String());
            AddColumn("dbo.Projects", "Video", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Video");
            DropColumn("dbo.Projects", "Story");
        }
    }
}
