using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace v2.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Story { get; set; }

        // Foreign Key for the Department 
        public int DepartmentID { get; set; }

        public Department Department { get; set; }
    }
}