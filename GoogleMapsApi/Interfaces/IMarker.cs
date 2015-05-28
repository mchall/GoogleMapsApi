using System;

namespace GoogleMapsApi
{
    public interface IMarker
    {
        /// <summary>
        /// This event is fired when the marker icon was clicked.
        /// </summary>
        event Action<IMarker, GeographicLocation> Click;

        /// <summary>
        /// This event is fired for a rightclick on the marker.
        /// </summary>
        event Action<IMarker, GeographicLocation> RightClick;

        /// <summary>
        /// This event is fired when the marker icon was double clicked.
        /// </summary>
        event Action<IMarker, GeographicLocation> DoubleClick;

        /// <summary>
        /// This event is fired when the user stops dragging the marker.
        /// </summary>
        event Action<IMarker, GeographicLocation> DragEnd;

        /// <summary>
        /// The ID of the marker
        /// </summary>
        int MarkerId { get; }

        /// <summary>
        /// The position of the marker
        /// </summary>
        GeographicLocation Position { get; }

        /// <summary>
        /// Visibility of the Marker
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// Start an animation. Any ongoing animation will be cancelled. Currently supported animations are: BOUNCE, DROP. Passing in null will cause any animation to stop.
        /// </summary>
        void PlayAnimation(MarkerAnimation? animation);
    }
}