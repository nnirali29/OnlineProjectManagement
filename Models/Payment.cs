using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineProjectManagement.Models
{
    public class Payment
    {
        [Key]
        public int Payid { get; set; }
        public string Name { get; set; }
        public string PayAmmount { get; set; }
        public int ID { get; set; }
        public string PaymentMethod { get; set; }
        public string Status { get; set; }
        public DateTime  Paymentdate { get; set; }

    }
}