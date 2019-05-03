namespace v2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using v2.Models;

    internal sealed class Configurationtwo : DbMigrationsConfiguration<v2.Models.ProjectDBContext>
    {
        public Configurationtwo()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "v2.Models.ProjectDBContext";
        }

        protected override void Seed(v2.Models.ProjectDBContext context)
        {
            context.Projects.AddOrUpdate(x => x.ProjectID,
                new Project()
                {
                    ProjectID = 1,
                    Title = "Generating electricity from microbial reactions from effluent only wastewater system.",
                    URL = "reposit.jpg",
                    DepartmentID = 1
                },
                new Project()
                {
                    ProjectID = 2,
                    Title = "Learn how to automate your home with XinaBox and Blynk with a simple demonstration of turning lights ON and OFF using the Blynk app button.",
                    URL = "daf2631a0229653845f4192012e5c136.png",
                    DepartmentID = 3
                },
                new Project()
                {
                    ProjectID = 3,
                    Title = "Using Teensy (small Arduino) to power NeoPixels off of an electric battery.",
                    URL = "wicard.jpg",
                    DepartmentID = 2
                }
                );

            context.Departments.AddOrUpdate(x => x.DepartmentID,
                new Department()
                {
                    DepartmentID = 1,
                    DepartmentName = "Arduino",
                },
                new Department()
                {
                    DepartmentID = 2,
                    DepartmentName = "Raspberry Pi",
                },
                new Department()
                {
                    DepartmentID = 3,
                    DepartmentName = "Internet Of Things",
                }
                );
        }
    }
}
