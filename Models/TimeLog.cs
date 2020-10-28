using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class TimeLog
    {

        [Key]
        public int GUID { get; set; }
        public string comment { get; set; }
       
        public string endate { get; set; }
        public DateTime  startdate { get; set; }
        public DateTime date { get; set; }

    }
}