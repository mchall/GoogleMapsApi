using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    [JsonObject(MemberSerialization.OptIn)]
    public class EncodedPolyline
    {
        /// <summary>
        /// Encoded string of locations.
        /// </summary>
        [JsonProperty("points")]
        public string EncodedPoints { get; set; }
    }
}