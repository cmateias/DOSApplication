using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSApplication.Models.DistanceResponse
{
    public class OriginDestination
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Status { get; set; }
        public Duration Duration { get; set; }
        public Distance Distance { get; set; }
    }
}