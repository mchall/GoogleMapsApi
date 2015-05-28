using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GoogleMapsApi
{
    public class CustomStringEnumConverter : StringEnumConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }
            catch (Exception)
            {
                if (objectType.IsValueType)
                    return Activator.CreateInstance(objectType); //Default enum value
                return null;
            }
        }
    }
}