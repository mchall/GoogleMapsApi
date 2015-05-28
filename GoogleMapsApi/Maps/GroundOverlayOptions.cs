using System;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#GroundOverlayOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GroundOverlayOptions
    {
        /// <summary>
        /// If true, the ground overlay can receive mouse events.
        /// </summary>
        [JsonProperty("clickable")]
        public bool Clickable { get; set; }

        /// <summary>
        /// The opacity of the overlay, expressed as a number between 0 and 1. Optional. Defaults to 1.
        /// </summary>
        [JsonProperty("opacity")]
        public double Opacity { get; set; }

        public GroundOverlayOptions()
        {
            Clickable = true;
            Opacity = 1;
        }
    }
}