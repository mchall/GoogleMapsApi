using System;
using System.Drawing;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#CircleOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class CircleOptions
    {
        /// <summary>
        /// Indicates whether this Circle handles mouse events. Defaults to true.
        /// </summary>
        [JsonProperty("clickable")]
        public bool Clickable { get; set; }

        /// <summary>
        /// If set to true, the user can edit this circle by dragging the control points shown at the center and around the circumference of the circle. Defaults to false.
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonIgnore]
        public Color FillColor { get; set; }

        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonProperty("fillColor")]
        public string FillColorHex
        {
            get { return Helpers.ConvertToHex(FillColor); }
        }

        /// <summary>
        /// The fill opacity between 0.0 and 1.0
        /// </summary>
        [JsonProperty("fillOpacity")]
        public double FillOpacity { get; set; }

        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonIgnore]
        public Color StrokeColor { get; set; }

        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonProperty("strokeColor")]
        public string StrokeColorHex
        {
            get { return Helpers.ConvertToHex(StrokeColor); }
        }

        /// <summary>
        /// The stroke opacity between 0.0 and 1.0
        /// </summary>
        [JsonProperty("strokeOpacity")]
        public double StrokeOpacity { get; set; }

        /// <summary>
        /// The stroke width in pixels.
        /// </summary>
        [JsonProperty("strokeWeight")]
        public double StrokeWeight { get; set; }

        public CircleOptions()
        {
            StrokeColor = Color.Red;
            StrokeOpacity = 0.8;
            StrokeWeight = 2;
            FillColor = Color.Red;
            FillOpacity = 0.35;
            Editable = false;
            Clickable = true;
        }
    }
}