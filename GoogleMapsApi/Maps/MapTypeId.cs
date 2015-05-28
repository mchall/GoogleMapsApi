using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#MapTypeId
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MapTypeId
    {
        /// <summary>
        /// This map type displays a transparent layer of major streets on satellite images.
        /// </summary>
        [EnumMember(Value = "hybrid")]
        Hybrid,

        /// <summary>
        /// This map type displays a normal street map.
        /// </summary>
        [EnumMember(Value = "roadmap")]
        Roadmap,

        /// <summary>
        /// This map type displays satellite images.
        /// </summary>
        [EnumMember(Value = "satellite")]
        Satellite,

        /// <summary>
        /// This map type displays maps with physical features such as terrain and vegetation.
        /// </summary>
        [EnumMember(Value = "terrain")]
        Terrain,
    }
}