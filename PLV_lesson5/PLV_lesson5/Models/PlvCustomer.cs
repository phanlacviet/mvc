using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLV_lesson5.Models
{
    public class PlvCustomer
    {
        public int customerid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public int yearofbirth { get; set; }
    }
}