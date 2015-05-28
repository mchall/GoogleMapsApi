using System;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#MapTypeControlStyle
    /// </summary>
    public enum MapTypeControlStyle
    {
        /// <summary>
        /// Uses the default map type control. The control which DEFAULT maps to will vary according to window size and other factors. It may change in future versions of the API.
        /// </summary>
        Default = 0,

        /// <summary>
        /// The standard horizontal radio buttons bar.
        /// </summary>
        HorizontalBar = 1,

        /// <summary>
        /// A dropdown menu for the screen realestate conscious.
        /// </summary>
        DropDownMenu = 2,
    }
}