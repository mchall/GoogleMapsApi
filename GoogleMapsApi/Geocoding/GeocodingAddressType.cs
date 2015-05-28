using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/geocoding#GeocodingAddressTypes
    /// </summary>
    [JsonConverter(typeof(CustomStringEnumConverter))]
    public enum GeocodingAddressType
    {
        Unknown,

        /// <summary>
        /// Indicates a precise street address.
        /// </summary>
        [EnumMember(Value = "street_address")]
        StreetAddress,

        /// <summary>
        /// Indicates a named route (such as "US 101").
        /// </summary>
        [EnumMember(Value = "route")]
        Route,

        /// <summary>
        /// Indicates a major intersection, usually of two major roads.
        /// </summary>
        [EnumMember(Value = "intersection")]
        Intersection,

        /// <summary>
        /// Indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        [EnumMember(Value = "political")]
        Political,

        /// <summary>
        /// Indicates the national political entity, and is typically the highest order type returned by the Geocoder.
        /// </summary>
        [EnumMember(Value = "country")]
        Country,

        /// <summary>
        /// Indicates a first-order civil entity below the country level. Within the United States, these administrative levels are states. Not all nations exhibit these administrative levels.
        /// </summary>
        [EnumMember(Value = "administrative_area_level_1")]
        AdministrativeAreaLevel1,

        /// <summary>
        /// Indicates a second-order civil entity below the country level. Within the United States, these administrative levels are counties. Not all nations exhibit these administrative levels.
        /// </summary>
        [EnumMember(Value = "administrative_area_level_2")]
        AdministrativeAreaLevel2,

        /// <summary>
        /// Indicates a third-order civil entity below the country level. This type indicates a minor civil division. Not all nations exhibit these administrative levels.
        /// </summary>
        [EnumMember(Value = "administrative_area_level_3")]
        AdministrativeAreaLevel3,

        /// <summary>
        /// Indicates a commonly-used alternative name for the entity.
        /// </summary>
        [EnumMember(Value = "colloquial_area")]
        ColloquialArea,

        /// <summary>
        /// Indicates an incorporated city or town political entity.
        /// </summary>
        [EnumMember(Value = "locality")]
        Locality,

        /// <summary>
        /// Indicates an first-order civil entity below a locality.
        /// </summary>
        [EnumMember(Value = "sublocality")]
        Sublocality,

        /// <summary>
        /// Indicates a named neighborhood.
        /// </summary>
        [EnumMember(Value = "neighborhood")]
        Neighborhood,

        /// <summary>
        /// Indicates a named location, usually a building or collection of buildings with a common name.
        /// </summary>
        [EnumMember(Value = "premise")]
        Premise,

        /// <summary>
        /// Indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name.
        /// </summary>
        [EnumMember(Value = "subpremise")]
        Subpremise,

        /// <summary>
        /// Indicates a postal code as used to address postal mail within the country.
        /// </summary>
        [EnumMember(Value = "postal_code")]
        PostalCode,

        /// <summary>
        /// Indicates a prominent natural feature.
        /// </summary>
        [EnumMember(Value = "natural_feature")]
        NaturalFeature,

        /// <summary>
        /// Indicates an airport.
        /// </summary>
        [EnumMember(Value = "airport")]
        Airport,

        /// <summary>
        /// Indicates a named park.
        /// </summary>
        [EnumMember(Value = "park")]
        Park,

        /// <summary>
        /// Indicates a specific postal box.
        /// </summary>
        [EnumMember(Value = "post_box")]
        PostBox,

        /// <summary>
        /// Indicates the precise street number.
        /// </summary>
        [EnumMember(Value = "street_number")]
        StreetNumber,

        /// <summary>
        /// Indicates the floor of a building address.
        /// </summary>
        [EnumMember(Value = "floor")]
        Floor,

        /// <summary>
        /// Indicates the room of a building address.
        /// </summary>
        [EnumMember(Value = "room")]
        Room
    }
}