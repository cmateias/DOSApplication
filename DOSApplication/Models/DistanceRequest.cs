using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSApplication.Models
{
    public class DistanceRequest
    {
        public string Origin{ get; set; }
        public string Destination { get; set; }
        public string Mode { get; set; }
    }
}