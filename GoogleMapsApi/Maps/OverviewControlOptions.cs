using System;
using System.Drawing;
using Newtonsoft.Json;
using System.ComponentModel;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#OverviewMapControlOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class OverviewControlOptions
    {
        /// <summary>
        /// Whether the control should display in opened mode or collapsed (minimized) mode. By default, the control is closed.
        /// </summary>
        [JsonProperty("opened")]
        public bool Open { get; set; }
    }
}