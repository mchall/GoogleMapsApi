using System;
using System.Drawing;
using Newtonsoft.Json;
using System.ComponentModel;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#RotateControlOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class RotateControlOptions
    {
        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        [JsonProperty("position")]
        public ControlPosition? Position { get; set; }
    }
}