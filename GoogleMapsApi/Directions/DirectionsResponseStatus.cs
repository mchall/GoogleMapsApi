using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/directions/#StatusCodes
    /// </summary>
    [JsonConverter(typeof(CustomStringEnumConverter))]
    public enum DirectionsResponseStatus
    {
        /// <summary>
        /// Indicates the response contains a valid result.
        /// </summary>
        [EnumMember(Value = "OK")]
        Ok,

        /// <summary>
        /// Indicates at least one of the locations specified in the requests's origin, destination, or waypoints could not be geocoded.
        /// </summary>
        [EnumMember(Value = "NOT_FOUND   ")]
        NotFound,

        /// <summary>
        /// Indicates no route could be found between the origin and destination.
        /// </summary>
        [EnumMember(Value = "ZERO_RESULTS  ")]
        ZeroResults,

        /// <summary>
        /// Indicates that too many waypointss were provided in the request The maximum allowed waypoints is 8, plus the origin, and destination. ( Google Maps API for Business customers may contain requests with up to 23 waypoints.)
        /// </summary>
        [EnumMember(Value = "MAX_WAYPOINTS_EXCEEDED  ")]
        MaxWaypointsExceeded,

        /// <summary>
        /// Indicates that the provided request was invalid.
        /// </summary>
        [EnumMember(Value = "INVALID_REQUEST  ")]
        InvalidRequest,

        /// <summary>
        /// Indicates the service has received too many requests from your application within the allowed time period.
        /// </summary>
        [EnumMember(Value = "OVER_QUERY_LIMIT  ")]
        OverQueryLimit,

        /// <summary>
        /// Indicates that the service denied use of the directions service by your application.
        /// </summary>
        [EnumMember(Value = "REQUEST_DENIED ")]
        RequestDenied,

        /// <summary>
        /// Indicates a directions request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        [EnumMember(Value = "UNKNOWN_ERROR  ")]
        Unknown,
    }
}