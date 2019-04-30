namespace v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dep02 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Projects", "DepartmentName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "DepartmentName", c => c.String());
        }
    }
}
