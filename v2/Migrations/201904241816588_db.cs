namespace v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "DepartmentName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "DepartmentName");
        }
    }
}
