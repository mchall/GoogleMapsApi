using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface ICircle
    {
        /// <summary>
        /// This event is fired when the DOM click event is fired on the Circle.
        /// </summary>
        event Action<ICircle, GeographicLocation> Click;

        /// <summary>
        /// This event is fired when the Circle is right-clicked on.
        /// </summary>
        event Action<ICircle, GeographicLocation> RightClick;

        /// <summary>
        /// This event is fired when the DOM dblclick event is fired on the Circle.
        /// </summary>
        event Action<ICircle, GeographicLocation> DoubleClick;

        /// <summary>
        /// The ID of the cirlce
        /// </summary>
        int CircleId { get; }

        /// <summary>
        /// The position of the circle
        /// </summary>
        GeographicLocation Position { get; }

        /// <summary>
        /// The radius of the circle
        /// </summary>
        double Radius { get; }

        /// <summary>
        /// Visibility of the Circle
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Whether this shape can be edited by the user.
        /// </summary>
        bool Editable { get; set; }
    }
}