using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IGoogleMapWrapper
    {
        /// <summary>
        /// Interact with the Street View
        /// </summary>
        IStreetView StreetView { get; }

        /// <summary>
        /// Methods for geometry
        /// </summary>
        IGeometry Geometry { get; }

        /// <summary>
        /// Options for rendering of the Map
        /// </summary>
        MapOptions MapOptions { get; }

        /// <summary>
        /// This event is fired when the user clicks on the map (but not when they click on a marker or infowindow).
        /// </summary>
        event Action<GeographicLocation> MapClick;

        /// <summary>
        /// This event is fired when the DOM contextmenu event is fired on the map container.
        /// </summary>
        event Action<GeographicLocation> MapRightClick;

        /// <summary>
        /// This event is fired when the user double-clicks on the map. Note that the click event will also fire, right before this one.
        /// </summary>
        event Action<GeographicLocation> MapDoubleClick;

        /// <summary>
        /// This event is fired when the map zoom property changes.
        /// </summary>
        event Action<int> ZoomChanged;

        /// <summary>
        /// This event is fired when the map center property changes.
        /// </summary>
        event Action<GeographicLocation> CenterChanged;

        /// <summary>
        /// This event is fired when the viewport bounds have changed.
        /// </summary>
        event Action<GeographicBounds> BoundsChanged;

        /// <summary>
        /// This event is fired when the map has resized.
        /// </summary>
        event Action MapResized;

        /// <summary>
        /// This event is fired when the user starts to drag the map.
        /// </summary>
        event Action MapDragStart;

        /// <summary>
        /// This event is fired when map drag ends.
        /// </summary>
        event Action MapDragEnd;

        /// <summary>
        /// This event is fired when the API is ready.
        /// </summary>
        event Action ApiReady;

        /// <summary>
        /// Using an API key enables you to monitor your application's Maps API usage, and ensures that Google can contact you about your application if necessary.
        /// </summary>
        string ApiKey { get; }

        /// <summary>
        /// Indicates whether this application uses a sensor (such as a GPS locator) to determine the user's location.
        /// </summary>
        bool Sensor { get; }

        /// <summary>
        /// Region localization.
        /// </summary>
        string RegionString { get; }

        /// <summary>
        /// Returns the position displayed at the center of the map. 
        /// </summary>
        GeographicLocation Center { get; set; }

        /// <summary>
        /// Returns the zoom of the map.
        /// </summary>
        int Zoom { get; set; }

        /// <summary>
        /// Updates the rendering options of the map
        /// </summary>
        void UpdateMapOptions();

        /// <summary>
        /// Sets the viewport to contain the given bounds.
        /// </summary>
        /// <param name="bounds">The new viewport bounds</param>
        void FitToBounds(GeographicBounds bounds);

        /// <summary>
        /// A service for converting between an address and a LatLng.
        /// </summary>
        /// <param name="address">The address to search for. Try be as specific as possible, ie: "Dean Street, Newlands, Cape Town"</param>
        /// <param name="region">Country code top-level domain within which to search. Optional.</param>
        /// <param name="bounds">The bounding box of the viewport within which to bias geocode results more prominently.</param>
        /// <returns>A single geocoder result retrieved from the geocode server. A geocode request may return multiple result objects.</returns>
        GeocodingResponse RunGeocoder(string address, string region = null, GeographicBounds bounds = null);

        /// <summary>
        /// A service for converting a LatLng to an address.
        /// </summary>
        /// <param name="location">The LatLng.</param>
        /// <returns>A single geocoder result retrieved from the geocode server. A geocode request may return multiple result objects.</returns>
        GeocodingResponse RunGeocoder(GeographicLocation location);

        /// <summary>
        /// The Google Directions API is a service that calculates directions between locations using an HTTP request
        /// </summary>
        /// <param name="origin">The address or textual latitude/longitude value from which you wish to calculate directions.</param>
        /// <param name="destination">The address or textual latitude/longitude value from which you wish to calculate directions.</param>
        /// <param name="additionalDetails">Additional details for directions API</param>
        /// <returns>A single distance result retrieved from the distance server. A distance request may return multiple result objects.</returns>
        DirectionsResponse RunDirections(string origin, string destination, DirectionsRequest additionalDetails);

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
        /// A polygon (like a polyline) defines a series of connected coordinates in an ordered sequence; additionally, polygons form a closed loop and define a filled region.
        /// </summary>
        /// <param name="locations">The locations that make up the polygon</param>
        /// <param name="polygonOptions">Options that determine how the polygon is rendered</param>
        /// <param name="hideOthers">Hides other drawn polygons</param>
        /// <returns>Polygon</returns>
        IPolygon DrawPolygon(List<GeographicLocation> locations, PolygonOptions polygonOptions, bool hideOthers = false);

        /// <summary>
        /// A polyline is a linear overlay of connected line segments on the map.
        /// </summary>
        /// <param name="locations">The locations that make up the polyline</param>
        /// <param name="polylineOptions">Options that determine how the polyline is rendered</param>
        /// <param name="hideOthers">Hides other drawn polylines</param>
        /// <returns>Polyline</returns>
        IPolyline DrawPolyline(List<GeographicLocation> locations, PolylineOptions polylineOptions, bool hideOthers = false);

        /// <summary>
        /// A circle on the Earth's surface; also known as a "spherical cap"
        /// </summary>
        /// <param name="center">The center</param>
        /// <param name="radius">The radius in meters on the Earth's surface</param>
        /// <param name="circleOptions">Options that determine how the circle is rendered</param>
        /// <param name="hideOthers">Hides other drawn circles</param>
        /// <returns>Circle</returns>
        ICircle DrawCircle(GeographicLocation center, double radius, CircleOptions circleOptions, bool hideOthers = false);

        /// <summary>
        /// A marker on the map.
        /// </summary>
        /// <param name="location">The location of the marker</param>
        /// <param name="markerOptions">Options that determine how the marker is rendered</param>
        /// <param name="hideOthers">Hides other markers on the map</param>
        /// <returns>Marker</returns>
        IMarker AddMarker(GeographicLocation location, MarkerOptions markerOptions, bool hideOthers = false);

        /// <summary>
        /// A rectangular image overlay on the map.
        /// </summary>
        /// <param name="imageUrl">The image for the overlay.</param>
        /// <param name="bounds">The GeographicBounds of this overlay.</param>
        /// <param name="groundOverlayOptions">Options that determine how the ground overlay is rendered</param>
        /// <returns>Ground overlay</returns>
        IGroundOverlay AddGroundOverlay(string imageUrl, GeographicBounds bounds, GroundOverlayOptions groundOverlayOptions);

        /// <summary>
        /// Cleans the map by hiding/closing all markers, polygons, circles, polyline, ground overlay and info windows
        /// </summary>
        void Clean();

        /// <summary>
        /// Changes the center of the map to the given LatLng. If the change is less than both the width and height of the map, the transition will be smoothly animated.
        /// </summary>
        /// <param name="location">GeographicLocation to pan to</param>
        void PanTo(GeographicLocation location);

        /// <summary>
        /// Pans the map by the minimum amount necessary to contain the given LatLngBounds. It makes no guarantee where on the map the bounds will be, except that as much of the bounds as possible will be visible. The bounds will be positioned inside the area bounded by the map type and navigation (pan, zoom, and Street View) controls, if they are present on the map. If the bounds is larger than the map, the map will be shifted to include the northwest corner of the bounds. If the change in the map's position is less than both the width and height of the map, the transition will be smoothly animated.
        /// </summary>
        /// <param name="bounds">GeographicBounds to pan to</param>
        void PanTo(GeographicBounds bounds);

        /// <summary>
        /// Changes the center of the map by the given distance in pixels. If the distance is less than both the width and height of the map, the transition will be smoothly animated. Note that the map coordinate system increases from west to east (for x values) and north to south (for y values).
        /// </summary>
        /// <param name="x">East/West value</param>
        /// <param name="y">North/South value</param>
        void PanBy(double x, double y);

        /// <summary>
        /// A rectangle overlay.
        /// </summary>
        /// <param name="bounds">The bounds of this rectangle</param>
        /// <param name="rectangleOptions">Options that determine how the polygon is rendered</param>
        /// <param name="hideOthers">Hides other drawn polygons</param>
        /// <returns>Rectangle</returns>
        IRectangle DrawRectangle(GeographicBounds bounds, RectangleOptions rectangleOptions, bool hideOthers = false);
    }
}