using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IPolyline
    {
        /// <summary>
        /// This event is fired when the DOM click event is fired on the Polygon.
        /// </summary>
        event Action<IPolyline, GeographicLocation> Click;

        /// <summary>
        /// This event is fired when the Polygon is right-clicked on.
        /// </summary>
        event Action<IPolyline, GeographicLocation> RightClick;

        /// <summary>
        /// This event is fired when the DOM dblclick event is fired on the Polygon.
        /// </summary>
        event Action<IPolyline, GeographicLocation> DoubleClick;

        /// <summary>
        /// The ID of the polyline
        /// </summary>
        int PolylineId { get; }

        /// <summary>
        /// The ordered sequence of coordinates of the Polyline.
        /// </summary>
        List<GeographicLocation> Paths { get; }

        /// <summary>
        /// Visibility of the Polyline
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Whether this shape can be edited by the user.
        /// </summary>
        bool Editable { get; set; }
    }
}