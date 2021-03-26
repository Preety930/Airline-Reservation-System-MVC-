using ARSDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ARS.Models
{
    public class SearchTicket
    {
       
            public AirCraft aircrafts { get; set; }
            public Flight_Schedule Flight { get; set; }
            public AirFare airFares { get; set; }
            public Route routes { get; set; }
        
    }
}