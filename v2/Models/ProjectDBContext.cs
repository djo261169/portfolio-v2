using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace v2.Models
{
    public class ProjectDBContext : DbContext
    {
        public ProjectDBContext() : base("ProjectDbContext")
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}