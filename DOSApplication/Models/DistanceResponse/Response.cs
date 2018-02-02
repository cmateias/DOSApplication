using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSApplication.Models.DistanceResponse
{
    //public class Response
    //{
    //    public string Status { get; set; }
    //    public List<string> OriginAddresses { get; set; }
    //    public List<string> DestinationAddresses { get; set; }
     //   public List<Rows> Rows { get; set; }
    //}

    public class Response
    {
        public string Status { get; set; }
        public List<OriginDestination> OriginDestination { get; set; }
    }
}