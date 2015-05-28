using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    [JsonObject(MemberSerialization.OptIn)]
    public class GeocodingResponse
    {
        [JsonProperty("status")]
        public ServiceResponseStatus Status { get; set; }

        [JsonProperty("results")]
        public List<GeocodingResult> Results { get; set; }

        public GeocodingResponse()
        {
            Results = new List<GeocodingResult>();
        }
    }
}