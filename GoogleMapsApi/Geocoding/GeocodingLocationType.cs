using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingResults
    /// </summary>
    [JsonConverter(typeof(CustomStringEnumConverter))]
    public enum GeocodingLocationType
    {
        Unknown,

        /// <summary>
        /// Indicates that the returned result reflects a precise geocode.
        /// </summary>
        [EnumMember(Value = "ROOFTOP")]
        Rooftop,

        /// <summary>
        /// Indicates that the returned result reflects an approximation (usually on a road) interpolated between two precise points (such as intersections). Interpolated results are generally returned when rooftop geocodes are unavailable for a street address.
        /// </summary>
        [EnumMember(Value = "RANGE_INTERPOLATED")]
        RangeInterpolated,

        /// <summary>
        /// Indicates that the returned result is the geometric center of a result such as a polyline (for example, a street) or polygon (region).
        /// </summary>
        [EnumMember(Value = "GEOMETRIC_CENTER")]
        GeometricCenter,

        /// <summary>
        /// Indicates that the returned result is approximate.
        /// </summary>
        [EnumMember(Value = "APPROXIMATE")]
        Approximate
    }
}