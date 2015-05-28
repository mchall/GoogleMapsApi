using System;
using Newtonsoft.Json;
using System.ComponentModel;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#ScaleControlOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ScaleControlOptions
    {
        /// <summary>
        /// Style id. Used to select what style of scale control to display.
        /// </summary>
        [JsonProperty("style")]
        public ScaleControlStyle? Style { get; set; }

        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is BOTTOM_LEFT.
        /// </summary>
        [JsonProperty("position")]
        public ControlPosition? Position { get; set; }
    }
}