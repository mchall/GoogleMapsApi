using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsResponse
    {
        [JsonProperty("status")]
        public DirectionsResponseStatus Status { get; set; }

        [JsonProperty("routes")]
        public List<DirectionsRoute> Routes { get; set; }

        public DirectionsResponse()
        {
            Routes = new List<DirectionsRoute>();
        }
    }
}