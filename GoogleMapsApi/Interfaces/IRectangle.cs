using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IRectangle
    {
        /// <summary>
        /// This event is fired when the DOM click event is fired on the Rectangle.
        /// </summary>
        event Action<IRectangle, GeographicLocation> Click;

        /// <summary>
        /// This event is fired when the Rectangle is right-clicked on.
        /// </summary>
        event Action<IRectangle, GeographicLocation> RightClick;

        /// <summary>
        /// This event is fired when the DOM dblclick event is fired on the Rectangle.
        /// </summary>
        event Action<IRectangle, GeographicLocation> DoubleClick;

        /// <summary>
        /// The ID of the Rectangle
        /// </summary>
        int RectangleId { get; }

        /// <summary>
        /// The bounds of this rectangle.
        /// </summary>
        GeographicBounds Bounds { get; }

        /// <summary>
        /// Visibility of the Rectangle
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Whether this shape can be edited by the user.
        /// </summary>
        bool Editable { get; set; }
    }
}