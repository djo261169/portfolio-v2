namespace v2.DefaultConnectionMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "FullName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String(nullable: false));
        }
    }
}
