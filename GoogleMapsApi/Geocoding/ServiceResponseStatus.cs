using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingStatusCodes
    /// </summary>
    [JsonConverter(typeof(CustomStringEnumConverter))]
    public enum ServiceResponseStatus
    {
        Unknown,

        /// <summary>
        /// Indicates that the geocode was successful.
        /// </summary>
        [EnumMember(Value = "OK")]
        Ok,

        /// <summary>
        /// Indicates that the geocode was successful but returned no results. This may occur if the geocode was passed a non-existent address or a latng in a remote location.
        /// </summary>
        [EnumMember(Value = "ZERO_RESULTS")]
        ZeroResults,

        /// <summary>
        /// Indicates that you are over your quota.
        /// </summary>
        [EnumMember(Value = "OVER_QUERY_LIMIT")]
        OverQueryLimit,

        /// <summary>
        /// Indicates that your request was denied for some reason.
        /// </summary>
        [EnumMember(Value = "REQUEST_DENIED")]
        RequestDenied,

        /// <summary>
        /// Generally indicates that the query (address or latLng) is missing.
        /// </summary>
        [EnumMember(Value = "INVALID_REQUEST")]
        InvalidRequest,
    }
}