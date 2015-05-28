using System;
using System.Drawing;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#PolygonOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class PolygonOptions
    {
        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonIgnore]
        public Color StrokeColor { get; set; }

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

        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonIgnore]
        public Color FillColor { get; set; }

        /// <summary>
        /// The fill opacity between 0.0 and 1.0
        /// </summary>
        [JsonProperty("fillOpacity")]
        public double FillOpacity { get; set; }

        /// <summary>
        /// If set to true, the user can edit this shape by dragging the control points shown at the vertices and on each segment. Defaults to false.
        /// </summary>
        [JsonProperty("editable")]
        public bool Editable { get; set; }

        /// <summary>
        /// When true, render each edge as a geodesic (a segment of a "great circle"). A geodesic is the shortest path between two points along the surface of the Earth. When false, render each edge as a straight line on screen. Defaults to false.
        /// </summary>
        [JsonProperty("geodesic")]
        public bool Geodesic { get; set; }

        /// <summary>
        /// Indicates whether this Polygon handles mouse events. Defaults to true.
        /// </summary>
        [JsonProperty("clickable")]
        public bool Clickable { get; set; }

        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonProperty("strokeColor")]
        public string StrokeColorHex
        {
            get { return Helpers.ConvertToHex(StrokeColor); }
        }

        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        [JsonProperty("fillColor")]
        public string FillColorHex
        {
            get { return Helpers.ConvertToHex(FillColor); }
        }

        public PolygonOptions()
        {
            StrokeColor = Color.Red;
            StrokeOpacity = 0.8;
            StrokeWeight = 2;
            FillColor = Color.Red;
            FillOpacity = 0.35;
            Editable = false;
            Geodesic = false;
            Clickable = true;
        }
    }
}