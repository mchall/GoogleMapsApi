using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#GeocoderResult
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class GeocodingResult
    {
        /// <summary>
        /// An array of GeocoderAddressComponents
        /// </summary>
        [JsonProperty("address_components")]
        public List<GeocodingAdressComponent> AddressComponents { get; set; }

        /// <summary>
        /// A string containing the human-readable address of this location.
        /// </summary>
        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// A GeocoderGeometry object
        /// </summary>
        [JsonProperty("geometry")]
        public GeocodingGeometry Geometry { get; set; }

        /// <summary>
        /// An array of strings denoting the type of the returned geocoded element. For a list of possible strings, refer to the Address Component Types section of the Developer's Guide.
        /// </summary>
        [JsonProperty("types")]
        public List<GeocodingAddressType> Types { get; set; }

        public GeocodingResult()
        {
            AddressComponents = new List<GeocodingAdressComponent>();
            Types = new List<GeocodingAddressType>();
        }
    }
}