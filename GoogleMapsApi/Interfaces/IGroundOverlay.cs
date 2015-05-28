using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IGroundOverlay
    {
        /// <summary>
        /// This event is fired when the DOM click event is fired on the Ground Overlay.
        /// </summary>
        event Action<IGroundOverlay, GeographicLocation> Click;

        /// <summary>
        /// This event is fired when the DOM dblclick event is fired on the Ground Overlay.
        /// </summary>
        event Action<IGroundOverlay, GeographicLocation> DoubleClick;

        /// <summary>
        /// The ID of the ground overlay
        /// </summary>
        int GroundOverlayId { get; }

        /// <summary>
        /// The opacity of the overlay, expressed as a number between 0 and 1.
        /// </summary>
        double Opacity { get; set; }
    }
}