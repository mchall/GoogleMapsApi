using System;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#ZoomControlStyle
    /// </summary>
    public enum ZoomControlStyle
    {
        /// <summary>
        /// The default zoom control. The control which DEFAULT maps to will vary according to map size and other factors. It may change in future versions of the API.
        /// </summary>
        Default = 0,

        /// <summary>
        /// A small control with buttons to zoom in and out.
        /// </summary>
        Small = 1,

        /// <summary>
        /// The larger control, with the zoom slider in addition to +/- buttons.
        /// </summary>
        Large = 2,
    }
}