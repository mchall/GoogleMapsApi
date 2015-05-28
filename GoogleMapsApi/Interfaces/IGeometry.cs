using System;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public interface IGeometry
    {
        /// <summary>
        /// Returns a list of locations from the encoded string returned from the distance API
        /// </summary>
        /// <param name="polyline">Encoded polyline returned from distance API</param>
        /// <returns>List of locations to make up a polyline</returns>
        List<GeographicLocation> DecodePolyline(EncodedPolyline polyline);

        /// <summary>
        /// Computes whether the given point lies inside the specified polygon.
        /// </summary>
        /// <param name="polygon">Polygon to check against</param>
        /// <param name="location">Point to check</param>
        /// <returns>True if point inside polygon</returns>
        bool ContainsLocation(IPolygon polygon, GeographicLocation location);

        /// <summary>
        /// Computes whether the given point lies on the edge of a polygon, within a specified tolerance.
        /// </summary>
        /// <param name="polygon">Polygon to check against</param>
        /// <param name="location">Point to check</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if point on edge of polygon</returns>
        bool IsLocationOnEdge(IPolygon polygon, GeographicLocation location, double? tolerance);

        /// <summary>
        /// Computes whether the given point lies on or near to a polyline within a specified tolerance.
        /// </summary>
        /// <param name="polyline">Polyline to check against</param>
        /// <param name="location">Point to check</param>
        /// <param name="tolerance">Tolerance</param>
        /// <returns>True if point on edge of polyline</returns>
        bool IsLocationOnEdge(IPolyline polyline, GeographicLocation location, double? tolerance);

        /// <summary>
        /// Returns the area of a closed path. 
        /// </summary>
        /// <param name="locations">Locations that make up the path</param>
        /// <returns>Area (in meters)</returns>
        double ComputeArea(List<GeographicLocation> locations);

        /// <summary>
        /// Returns the distance between two LatLngs.
        /// </summary>
        /// <param name="from">Location to measure from</param>
        /// <param name="to">Location to measure to</param>
        /// <returns>Distance (in meters)</returns>
        double ComputeDistanceBetween(GeographicLocation from, GeographicLocation to);

        /// <summary>
        /// Returns the heading (expressed in degrees clockwise from north) from one LatLng to another LatLng.
        /// </summary>
        /// <param name="from">Location to measure from</param>
        /// <param name="to">Location to measure to</param>
        /// <returns>Heading (in degrees)</returns>
        double ComputeHeading(GeographicLocation from, GeographicLocation to);

        /// <summary>
        /// Returns the length of the given path.
        /// </summary>
        /// <param name="locations">Locations that make up the path</param>
        /// <returns>Length (in meters)</returns>
        double ComputeLength(List<GeographicLocation> locations);

        /// <summary>
        /// Returns the LatLng resulting from moving a distance from an origin in the specified heading (expressed in degrees clockwise from north).
        /// </summary>
        /// <param name="from">Origin location</param>
        /// <param name="distance">Distance offset (in meters)</param>
        /// <param name="heading">Heading offset (in degrees)</param>
        /// <returns>Resulting location</returns>
        GeographicLocation ComputeOffset(GeographicLocation from, double distance, double heading);

        /// <summary>
        /// Returns the LatLng which lies the given fraction of the way between the origin LatLng and the destination LatLng.
        /// </summary>
        /// <param name="from">Start location</param>
        /// <param name="to">End location</param>
        /// <param name="fraction">The fraction</param>
        /// <returns>Location at fraction between start and end points</returns>
        GeographicLocation Interpolate(GeographicLocation from, GeographicLocation to, double fraction);
    }
}