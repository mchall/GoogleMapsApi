using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IPolygon
    {
        /// <summary>
        /// This event is fired when the DOM click event is fired on the Polygon.
        /// </summary>
        event Action<IPolygon, GeographicLocation> Click;

        /// <summary>
        /// This event is fired when the Polygon is right-clicked on.
        /// </summary>
        event Action<IPolygon, GeographicLocation> RightClick;

        /// <summary>
        /// This event is fired when the DOM dblclick event is fired on the Polygon.
        /// </summary>
        event Action<IPolygon, GeographicLocation> DoubleClick;

        /// <summary>
        /// The ID of the polygon
        /// </summary>
        int PolygonId { get; }

        /// <summary>
        /// The paths of the polygon
        /// </summary>
        List<GeographicLocation> Paths { get; }

        /// <summary>
        /// Visibility of the Polygon
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Whether this shape can be edited by the user.
        /// </summary>
        bool Editable { get; set; }
    }
}