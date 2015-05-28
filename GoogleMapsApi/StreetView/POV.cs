using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#StreetViewPov
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class POV
    {
        /// <summary>
        /// The camera heading in degrees relative to true north. True north is 0°, east is 90°, south is 180°, west is 270°.
        /// </summary>
        [JsonProperty("heading")]
        public double Heading { get; set; }

        /// <summary>
        /// The camera pitch in degrees, relative to the street view vehicle. Ranges from 90° (directly upwards) to -90° (directly downwards).
        /// </summary>
        [JsonProperty("pitch")]
        public double Pitch { get; set; }

        /// <summary>
        /// The zoom level. Fully zoomed-out is level 0, zooming in increases the zoom level.
        /// </summary>
        [JsonProperty("zoom")]
        public double Zoom { get; set; }

        public POV()
        {
            Heading = 0;
            Pitch = 0;
            Zoom = 1;
        }
    }
}