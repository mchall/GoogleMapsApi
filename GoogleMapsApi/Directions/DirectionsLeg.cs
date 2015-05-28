using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/directions/#Legs
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsLeg
    {
        /// <summary>
        /// The total distance covered by this leg. This property may be undefined as the distance may be unknown.
        /// </summary>
        [JsonProperty("distance")]
        public DirectionsDistance Distance { get; set; }

        /// <summary>
        /// The total duration of this leg. This property may be undefined as the duration may be unknown.
        /// </summary>
        [JsonProperty("duration")]
        public DirectionsDuration Duration { get; set; }

        /// <summary>
        /// The address of the destination of this leg.
        /// </summary>
        [JsonProperty("end_address")]
        public string EndAddress { get; set; }

        /// <summary>
        /// The DirectionsService calculates directions between locations by using the nearest transportation option (usually a road) at the start and end locations. end_location indicates the actual geocoded destination, which may be different than the end_location of the last step if, for example, the road is not near the destination of this leg.
        /// </summary>
        [JsonProperty("end_location")]
        public GeographicLocation EndLocation { get; set; }

        /// <summary>
        /// The address of the origin of this leg.
        /// </summary>
        [JsonProperty("start_address")]
        public string StartAddress { get; set; }

        /// <summary>
        /// The DirectionsService calculates directions between locations by using the nearest transportation option (usually a road) at the start and end locations. start_location indicates the actual geocoded origin, which may be different than the start_location of the first step if, for example, the road is not near the origin of this leg.
        /// </summary>
        [JsonProperty("start_location")]
        public GeographicLocation StartLocation { get; set; }

        /// <summary>
        /// Contains an array of steps denoting information about each separate step of the leg of the journey.
        /// </summary>
        [JsonProperty("steps")]
        public List<DirectionsStep> Steps { get; set; }

        /// <summary>
        /// An array of waypoints along this leg that were not specified in the original request, either as a result of a user dragging the polyline or selecting an alternate route.
        /// </summary>
        [JsonProperty("via_waypoints")]
        public List<GeographicLocation> ViaWaypoints { get; set; }

        public DirectionsLeg()
        {
            Steps = new List<DirectionsStep>();
            ViaWaypoints = new List<GeographicLocation>();
        }
    }
}