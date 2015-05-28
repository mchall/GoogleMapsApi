using System;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#StreetViewPanoramaOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StreetViewOptions
    {
        /// <summary>
        /// The enabled/disabled state of the address control.
        /// </summary>
        [JsonProperty("addressControl")]
        public bool ShowAddressControl { get; set; }

        /// <summary>
        /// The display options for the address control.
        /// </summary>
        [JsonProperty("addressControlOptions")]
        public AddressControlOptions AddressControlOptions { get; set; }

        /// <summary>
        /// The enabled/disabled state of click-to-go.
        /// </summary>
        [JsonProperty("clickToGo")]
        public bool ClickToGo { get; set; }

        /// <summary>
        /// Enables/disables zoom on double click. Disabled by default.
        /// </summary>
        [JsonProperty("disableDoubleClickZoom")]
        public bool DisableDoubleClickZoom { get; set; }

        /// <summary>
        /// If true, the close button is displayed.
        /// </summary>
        [JsonProperty("enableCloseButton")]
        public bool ShowCloseButton { get; set; }

        /// <summary>
        /// The enabled/disabled state of the imagery acquisition date control.
        /// </summary>
        [JsonProperty("imageDateControl")]
        public bool ShowImageDateControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the links control.
        /// </summary>
        [JsonProperty("linksControl")]
        public bool ShowLinksControl { get; set; }

        /// <summary>
        /// The enabled/disabled state of the pan control.
        /// </summary>
        [JsonProperty("panControl")]
        public bool ShowPanControl { get; set; }

        /// <summary>
        /// The display options for the pan control.
        /// </summary>
        [JsonProperty("panControlOptions")]
        public PanControlOptions PanControlOptions { get; set; }

        /// <summary>
        /// The LatLng position of the Street View panorama.
        /// </summary>
        [JsonProperty("position")]
        public GeographicLocation Position { get; set; }

        /// <summary>
        /// The LatLng position of the Street View panorama.
        /// </summary>
        [JsonProperty("pov")]
        public POV POV { get; set; }

        /// <summary>
        /// If false, disables scrollwheel zooming in Street View. The scrollwheel is enabled by default.
        /// </summary>
        [JsonProperty("scrollwheel")]
        public bool ShowScrollWheel { get; set; }

        /// <summary>
        /// The camera orientation, specified as heading, pitch, and zoom, for the panorama.
        /// </summary>
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        /// <summary>
        /// The enabled/disabled state of the zoom control.
        /// </summary>
        [JsonProperty("zoomControl")]
        public bool ShowZoomControl { get; set; }

        /// <summary>
        /// The display options for the zoom control.
        /// </summary>
        [JsonProperty("zoomControlOptions")]
        public ZoomControlOptions ZoomControlOptions { get; set; }

        public StreetViewOptions()
        {
            ShowAddressControl = true;
            ClickToGo = true;
            DisableDoubleClickZoom = true;
            ShowCloseButton = true;
            ShowImageDateControl = true;
            ShowLinksControl = true;
            ShowPanControl = true;
            PanControlOptions = new GoogleMapsApi.PanControlOptions();
            POV = new POV();
            ShowScrollWheel = true;
            Visible = false;
            ShowZoomControl = true;
            ZoomControlOptions = new ZoomControlOptions();
        }
    }
}