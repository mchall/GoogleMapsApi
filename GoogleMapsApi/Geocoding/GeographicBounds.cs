using System;
using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#LatLng
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeographicBounds
    {
        [JsonProperty("northeast")]
        public GeographicLocation NorthEast { get; set; }

        [JsonProperty("southwest")]
        public GeographicLocation SouthWest { get; set; }
    }
}