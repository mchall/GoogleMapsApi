using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace GoogleMapsApi
{
    public enum DirectionsUnitSystem
    {
        [EnumMember(Value = "metric ")]
        Metric,

        [EnumMember(Value = "imperial ")]
        Imperial,
    }
}