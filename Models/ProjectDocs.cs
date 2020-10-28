using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class ProjectDocs
    {
        [Key]
        public int id { get; set; }
        //[ForeignKey("Project")]
        public int pId { get; set; }
        public string Did { get; set; }
        public string Docname { get; set; }
        public string active { get; set; }
        //public ICollection<ProjectDocs> projectDocs { get; set; }

    }
}