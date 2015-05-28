using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#Distance
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsDistance
    {
        /// <summary>
        /// A string representation of the distance value, using the UnitSystem specified in the request.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The distance in meters.
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}