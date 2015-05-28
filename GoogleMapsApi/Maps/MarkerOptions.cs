using System;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#MarkerOptions
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class MarkerOptions
    {
        /// <summary>
        /// Which animation to play when marker is added to a map.
        /// </summary>
        [JsonProperty("animation")]
        public MarkerAnimation? Animation { get; set; }

        /// <summary>
        /// If true, the marker receives mouse and touch events. Default value is true.
        /// </summary>
        [JsonProperty("clickable")]
        public bool Clickable { get; set; }

        /// <summary>
        /// Mouse cursor to show on hover
        /// </summary>
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        /// <summary>
        /// If true, the marker can be dragged. Default value is false.
        /// </summary>
        [JsonProperty("draggable")]
        public bool DraggingEnabled { get; set; }

        /// <summary>
        /// If true, the marker shadow will not be displayed.
        /// </summary>
        [JsonProperty("flat")]
        public bool Flat { get; set; }

        /// <summary>
        /// Icon for the foreground
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Optimization renders many markers as a single static element. Optimized rendering is enabled by default. Disable optimized rendering for animated GIFs or PNGs, or when each marker must be rendered as a separate DOM element (advanced usage only).
        /// </summary>
        [JsonProperty("optimized")]
        public bool Optimized { get; set; }

        /// <summary>
        /// If false, disables raising and lowering the marker on drag. This option is true by default.
        /// </summary>
        [JsonProperty("raiseOnDrag")]
        public bool RaiseOnDrag { get; set; }

        /// <summary>
        /// Shadow image
        /// </summary>
        [JsonProperty("shadow")]
        public string ShadowIcon { get; set; }

        /// <summary>
        /// Rollover text
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        public MarkerOptions()
        {
            Clickable = true;
            DraggingEnabled = false;
            Flat = false;
            Optimized = true;
            RaiseOnDrag = true;
        }
    }
}