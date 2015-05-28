using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#GeocoderGeometry
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeocodingGeometry
    {
        /// <summary>
        /// The precise bounds of this GeocodeResult, if applicable
        /// </summary>
        [JsonProperty("bounds")]
        public GeographicBounds Bounds { get; set; }

        /// <summary>
        /// The latitude/longitude coordinates of this result
        /// </summary>
        [JsonProperty("location")]
        public GeographicLocation Location { get; set; }

        /// <summary>
        /// The type of location returned in location
        /// </summary>
        [JsonProperty("location_type")]
        public GeocodingLocationType LocationType { get; set; }

        /// <summary>
        /// The bounds of the recommended viewport for displaying this GeocodeResult
        /// </summary>
        [JsonProperty("viewport")]
        public GeographicBounds ViewPort { get; set; }
    }
}