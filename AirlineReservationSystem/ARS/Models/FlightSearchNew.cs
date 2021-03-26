using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ARS.Models
{
    public class FlightSearchNew
    {
        [Key]
        public string AcNumber { get; set; }
        public string Airport { get; set; }
        public string Destination { get; set; }
        public int Capacity { get; set; }
        public Nullable<System.DateTime> Departure { get; set; }
        public Nullable<System.DateTime> Arrival { get; set; }
        public Nullable<decimal> Fare { get; set; }
    }
}