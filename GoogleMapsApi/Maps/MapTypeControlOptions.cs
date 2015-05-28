using System;
using System.Drawing;
using Newtonsoft.Json;
using System.ComponentModel;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#MapTypeControlOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MapTypeControlOptions
    {
        /// <summary>
        /// Style id. Used to select what style of map type control to display.
        /// </summary>
        [JsonProperty("style")]
        public MapTypeControlStyle? Style { get; set; }

        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_RIGHT.
        /// </summary>
        [JsonProperty("position")]
        public ControlPosition? Position { get; set; }
    }
}