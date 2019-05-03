namespace v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "Video");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "Video", c => c.String());
        }
    }
}
