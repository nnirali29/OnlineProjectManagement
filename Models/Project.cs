using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public DateTime  Duedate { get; set; }
        public string priority { get; set; }
        public string Status { get; set; }
        public decimal isActive { get; set; }
        //public ICollection<ProjectDocs> projectDocs  { get; set; }

    }
}