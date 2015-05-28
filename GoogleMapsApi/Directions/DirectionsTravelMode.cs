using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#TravelMode
    /// </summary>
    [JsonConverter(typeof(CustomStringEnumConverter))]
    public enum DirectionsTravelMode
    {
        /// <summary>
        /// Specifies a bicycling directions request.
        /// </summary>
        [EnumMember(Value = "BICYCLING")]
        Bicycling,

        /// <summary>
        /// Specifies a driving directions request.
        /// </summary>
        [EnumMember(Value = "DRIVING")]
        Driving,

        /// <summary>
        /// Specifies a walking directions request.
        /// </summary>
        [EnumMember(Value = "WALKING")]
        Walking,
    }
}