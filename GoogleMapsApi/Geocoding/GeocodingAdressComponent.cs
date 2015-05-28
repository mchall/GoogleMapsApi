using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#GeocoderAddressComponent
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeocodingAdressComponent
    {
        /// <summary>
        /// The full text of the address component
        /// </summary>
        [JsonProperty("long_name")]
        public string FullName { get; set; }

        /// <summary>
        /// The abbreviated, short text of the given address component
        /// </summary>
        [JsonProperty("short_name")]
        public string ShortName { get; set; }

        /// <summary>
        /// An array of strings denoting the type of this address component
        /// </summary>
        [JsonProperty("types")]
        public List<GeocodingAddressType> Types { get; set; }

        public GeocodingAdressComponent()
        {
            Types = new List<GeocodingAddressType>();
        }
    }
}