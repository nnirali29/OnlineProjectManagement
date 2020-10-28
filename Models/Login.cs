using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class Login
    {
     
        [Key,ForeignKey("users")]
        public int Id { get; set; }
       
        public string userName { get; set; }
       
        public decimal password { get; set; }
        public float active { get; set; }
        public virtual users users { get; set; }
    }
}