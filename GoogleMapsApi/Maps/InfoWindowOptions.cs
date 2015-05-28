using System;
using System.Drawing;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#InfoWindowOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class InfoWindowOptions
    {
        /// <summary>
        /// Disable auto-pan on open. By default, the info window will pan the map so that it is fully visible when it opens.
        /// </summary>
        [JsonProperty("disableAutoPan")]
        public bool DisableAutoPan { get; set; }

        /// <summary>
        /// Maximum width of the infowindow, regardless of content's width. This value is only considered if it is set before a call to open. To change the maximum width when changing content, call close, setOptions, and then open.
        /// </summary>
        [JsonProperty("maxWidth")]
        public double? MaxWidth { get; set; }

        /// <summary>
        /// The offset, in pixels, of the tip of the info window from the point on the map at whose geographical coordinates the info window is anchored. If an InfoWindow is opened with an anchor, the pixelOffset will be calculated from the top-center of the anchor's bounds.
        /// </summary>
        [JsonProperty("pixelOffset")]
        public Size PixelOffset { get; set; }

        /// <summary>
        /// All InfoWindows are displayed on the map in order of their zIndex, with higher values displaying in front of InfoWindows with lower values. By default, InfoWinodws are displayed according to their latitude, with InfoWindows of lower latitudes appearing in front of InfoWindows at higher latitudes. InfoWindows are always displayed in front of markers.
        /// </summary>
        [JsonProperty("zIndex")]
        public int? ZIndex { get; set; }

        public InfoWindowOptions()
        {
            PixelOffset = new Size();
        }
    }
}