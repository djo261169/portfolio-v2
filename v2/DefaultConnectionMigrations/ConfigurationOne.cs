namespace v2.DefaultConnectionMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationOne : DbMigrationsConfiguration<v2.Models.ApplicationDbContext>
    {
        public ConfigurationOne()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DefaultConnectionMigrations";
            ContextKey = "v2.Models.ApplicationDbContext";
        }

        protected override void Seed(v2.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
