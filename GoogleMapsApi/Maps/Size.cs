using System;
using System.Drawing;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#Size
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Size
    {
        /// <summary>
        /// The height along the y-axis, in pixels.
        /// </summary>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// The width along the x-axis, in pixels.
        /// </summary>
        [JsonProperty("width")]
        public double Width { get; set; }
    }
}