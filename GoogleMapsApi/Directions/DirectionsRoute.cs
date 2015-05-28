using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/directions/#Routes
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsRoute
    {
        /// <summary>
        /// Contains a short textual description for the route, suitable for naming and disambiguating the route from alternatives.
        /// </summary>
        [JsonProperty("summary ")]
        public string Summary { get; set; }

        /// <summary>
        /// Contains the viewport bounding box of this route.
        /// </summary>
        [JsonProperty("bounds")]
        public GeographicBounds Bounds { get; set; }

        /// <summary>
        /// Copyrights text to be displayed for this route.
        /// </summary>
        [JsonProperty("copyrights")]
        public string Copyrights { get; set; }

        /// <summary>
        /// Contains an array which contains information about a leg of the route, between two locations within the given route. A separate leg will be present for each waypoint or destination specified. (A route with no waypoints will contain exactly one leg within the legs array.) Each leg consists of a series of steps.
        /// </summary>
        [JsonProperty("legs")]
        public List<DirectionsLeg> Legs { get; set; }

        /// <summary>
        /// Contains an object holding an array of encoded points that represent an approximate (smoothed) path of the resulting directions.
        /// </summary>
        [JsonProperty("overview_polyline")]
        public EncodedPolyline OverviewPolyline { get; set; }

        /// <summary>
        /// Contains an array of warnings to be displayed when showing these directions. You must handle and display these warnings yourself.
        /// </summary>
        [JsonProperty("warnings")]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Contains an array indicating the order of any waypoints in the calculated route. This waypoints may be reordered if the request was passed optimize:true within its waypoints parameter.
        /// </summary>
        [JsonProperty("waypoint_order")]
        public List<int> WaypointOrder { get; set; }

        public DirectionsRoute()
        {
            Legs = new List<DirectionsLeg>();
            Warnings = new List<string>();
            WaypointOrder = new List<int>();
        }
    }
}