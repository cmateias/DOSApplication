using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSApplication.Dtl
{
    public class DistanceMatrix
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("origin_addresses")]
        public List<string> OriginAddresses { get; set; }
        [JsonProperty("destination_addresses")]
        public List<string> DestinationAddresses { get; set; }

        [JsonProperty("rows")]
        public List<Rows> Rows { get; set; }


    }

    public class Rows
    {
        [JsonProperty("elements")]
        public List<Elements> Elements { get; set; }
    }

    public class Elements
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("distance")]
        public Duration Distance { get; set; }
    }

    public class Duration
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Distance
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}