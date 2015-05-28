using System;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#MapOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MapOptions
    {
        /// <summary>
        /// The initial Map zoom level. Required.
        /// </summary>
        [JsonProperty("zoom")]
        public int Zoom { get; set; }

        /// <summary>
        /// The initial Map center. Required.
        /// </summary>
        [JsonProperty("center")]
        public GeographicLocation Center { get; set; }

        /// <summary>
        /// The initial Map mapTypeId. Required.
        /// </summary>
        [JsonProperty("mapTypeId")]
        public MapTypeId MapType { get; set; }

        /// <summary>
        /// The initial enabled/disabled state of the Street View Pegman control. This control is part of the default UI, and should be set to false when displaying a map type on which the Street View road overlay should not appear (e.g. a non-Earth map type).
        /// </summary>
        [JsonProperty("streetViewControl")]
        public bool ShowStreetViewControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Zoom control.
        /// </summary>
        [JsonProperty("zoomControl")]
        public bool ShowZoomControl { get; set; }

        /// <summary>
        /// If false, disables scrollwheel zooming on the map. The scrollwheel is enabled by default.
        /// </summary>
        [JsonProperty("scrollwheel")]
        public bool AllowScrollWheel { get; set; }

        /// <summary>
        /// The initial enabled/disabled state of the Scale control.
        /// </summary>
        [JsonProperty("scaleControl")]
        public bool ShowScaleControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Rotate control.
        /// </summary>
        [JsonProperty("rotateControl")]
        public bool ShowRotateControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Pan control.
        /// </summary>
        [JsonProperty("panControl")]
        public bool ShowPanControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the Overview Map control.
        /// </summary>
        [JsonProperty("overviewMapControl")]
        public bool ShowOverviewMapControl { get; set; }

        /// <summary>
        /// The minimum zoom level which will be displayed on the map. If omitted, or set to null, the minimum zoom from the current map type is used instead.
        /// </summary>
        [JsonProperty("minZoom")]
        public int? MinimumZoom { get; set; }

        /// <summary>
        /// The maximum zoom level which will be displayed on the map. If omitted, or set to null, the maximum zoom from the current map type is used instead.
        /// </summary>
        [JsonProperty("maxZoom")]
        public int? MaximumZoom { get; set; }

        /// <summary>
        /// The initial enabled/disabled state of the Map type control.
        /// </summary>
        [JsonProperty("mapTypeControl")]
        public bool ShowMapTypeControl { get; set; }

        /// <summary>
        /// True if Map Maker tiles should be used instead of regular tiles.
        /// </summary>
        [JsonProperty("mapMaker")]
        public bool ShowMapMakers { get; set; }

        /// <summary>
        /// If false, prevents the map from being controlled by the keyboard. Keyboard shortcuts are enabled by default.
        /// </summary>
        [JsonProperty("keyboardShortcuts")]
        public bool KeyboardShortcutsEnabled { get; set; }

        /// <summary>
        /// If false, prevents the map from being dragged. Dragging is enabled by default.
        /// </summary>
        [JsonProperty("draggable")]
        public bool DraggingEnabled { get; set; }

        /// <summary>
        /// Enables/disables zoom and center on double click. Enabled by default.
        /// </summary>
        [JsonProperty("disableDoubleClickZoom")]
        public bool DisableDoubleClickZoom { get; set; }

        /// <summary>
        /// The angle of incidence of the map as measured in degrees from the viewport plane to the map plane. The only currently supported values are 0, indicating no angle of incidence (no tilt), and 45, indicating a tilt of 45deg;. 45deg; imagery is only available for SATELLITE and HYBRID map types, within some locations, and at some zoom levels.
        /// </summary>
        [JsonProperty("tilt")]
        public int Tilt { get; set; }

        /// <summary>
        /// The display options for the Zoom control.
        /// </summary>
        [JsonProperty("zoomControlOptions")]
        public ZoomControlOptions ZoomControlOptions { get; set; }

        /// <summary>
        /// The initial display options for the Street View Pegman control.
        /// </summary>
        [JsonProperty("streetViewControlOptions")]
        public StreetViewControlOptions StreetViewControlOptions { get; set; }

        /// <summary>
        /// The initial display options for the Scale control.
        /// </summary>
        [JsonProperty("scaleControlOptions")]
        public ScaleControlOptions ScaleControlOptions { get; set; }

        /// <summary>
        /// The display options for the Rotate control.
        /// </summary>
        [JsonProperty("rotateControlOptions")]
        public RotateControlOptions RotateControlOptions { get; set; }

        /// <summary>
        /// The display options for the Pan control.
        /// </summary>
        [JsonProperty("panControlOptions")]
        public PanControlOptions PanControlOptions { get; set; }

        /// <summary>
        /// The display options for the Overview Map control.
        /// </summary>
        [JsonProperty("overviewMapControlOptions")]
        public OverviewControlOptions OverviewControlOptions { get; set; }

        /// <summary>
        /// The initial display options for the Map type control.
        /// </summary>
        [JsonProperty("mapTypeControlOptions")]
        public MapTypeControlOptions MapTypeControlOptions { get; set; }

        public MapOptions()
        {
            Zoom = 5;
            Center = new GeographicLocation(-26.68, 25.27); //South Africa
            MapType = MapTypeId.Roadmap;
            AllowScrollWheel = true;
            KeyboardShortcutsEnabled = true;
            DraggingEnabled = true;
            DisableDoubleClickZoom = false;

            ShowStreetViewControl = true;
            ShowZoomControl = true;
            ShowScaleControl = false;
            ShowRotateControl = false;
            ShowPanControl = true;
            ShowOverviewMapControl = false;
            ShowMapTypeControl = true;
            ShowMapMakers = false;

            ZoomControlOptions = new ZoomControlOptions();
            StreetViewControlOptions = new StreetViewControlOptions();
            ScaleControlOptions = new ScaleControlOptions();
            RotateControlOptions = new RotateControlOptions();
            PanControlOptions = new PanControlOptions();
            OverviewControlOptions = new OverviewControlOptions();
            MapTypeControlOptions = new MapTypeControlOptions();
        }
    }
}