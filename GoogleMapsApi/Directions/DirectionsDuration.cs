using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#Duration
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsDuration
    {
        /// <summary>
        /// A string representation of the duration value.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The duration in seconds.
        /// </summary>
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}