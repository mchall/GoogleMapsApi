using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleMapsApi
{
    public interface IStreetView
    {
        /// <summary>
        /// This event is fired when the panorama's position changes. The position changes as the user navigates through the panorama or the position is set manually.
        /// </summary>
        event Action<IStreetView, GeographicLocation> PositionChanged;

        /// <summary>
        /// This event is fired when the panorama's point-of-view changes. The point of view changes as the pitch, zoom, or heading changes.
        /// </summary>
        event Action<IStreetView, POV> POVChanged;

        /// <summary>
        /// This event is fired when the panorama's visibility changes. The visibility is changed when the Pegman id dragged onto the map, the close button is clicked, or setVisible() is called.
        /// </summary>
        event Action<IStreetView, bool> VisibleChanged;

        /// <summary>
        /// Gets/sets the current LatLng position for the Street View panorama.
        /// </summary>
        GeographicLocation Position { get; set; }

        /// <summary>
        /// Gets/sets the point of view for the Street View panorama.
        /// </summary>
        POV POV { get; set; }

        /// <summary>
        /// Gets/sets visibility of panorama.
        /// </summary>
        bool Visible { get; set; }

        /// <summary>
        /// An overlay that looks like a bubble and is often connected to a marker.
        /// </summary>
        /// <param name="contentString">This can be an HTML element, a plain-text string, or a string containing HTML</param>
        /// <param name="location">The location of the info window</param>
        /// <param name="infoWindowsOptions">Options that determine how the info window is rendered</param>
        /// <param name="hideOthers">Hides any other open info windows</param>
        /// <returns>Info window</returns>
        IInfoWindow ShowInfoWindow(string contentString, GeographicLocation location, InfoWindowOptions infoWindowsOptions, bool hideOthers = false);

        /// <summary>
        /// An overlay that looks like a bubble and is often connected to a marker.
        /// </summary>
        /// <param name="contentString">This can be an HTML element, a plain-text string, or a string containing HTML</param>
        /// <param name="marker">The marker to add the info window to</param>
        /// <param name="infoWindowsOptions">Options that determine how the info window is rendered</param>
        /// <param name="hideOthers">Hides any other open info windows</param>
        /// <returns>Info window</returns>
        IInfoWindow ShowInfoWindow(string contentString, IMarker marker, InfoWindowOptions infoWindowsOptions, bool hideOthers = false);

        /// <summary>
        /// A marker on the street view panorama.
        /// </summary>
        /// <param name="location">The location of the marker</param>
        /// <param name="markerOptions">Options that determine how the marker is rendered</param>
        /// <param name="hideOthers">Hides other markers on the map</param>
        /// <returns>Marker</returns>
        IMarker AddMarker(GeographicLocation location, MarkerOptions markerOptions, bool hideOthers = false);

        /// <summary>
        /// Cleans the street view panorama by hiding/closing all markers and info windows
        /// </summary>
        void Clean();
    }
}