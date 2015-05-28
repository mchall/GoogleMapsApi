using System;

namespace GoogleMapsApi
{
    public class GeocodingService
    {
        public static readonly Uri ApiUrl = new Uri("https://maps.google.com/maps/api/geocode/");

        public static GeocodingResponse GetResponse(string address, string region = null, GeographicBounds bounds = null)
        {
            var url = new Uri(String.Format("{0}json?address={1}&region={2}&sensor=false{3}", ApiUrl, Http.UrlEncoding(address), GetRegionString(region), GetBoundsString(bounds)));
            return Http.Get(url).As<GeocodingResponse>();
        }

        public static GeocodingResponse GetResponse(GeographicLocation location)
        {
            var url = new Uri(String.Format("{0}json?latlng={1},{2}&sensor=false", ApiUrl, location.Latitude, location.Longitude));
            return Http.Get(url).As<GeocodingResponse>();
        }

        private static object GetRegionString(string region)
        {
            if (!String.IsNullOrEmpty(region))
            {
                return String.Format("&region={0}", region);
            }
            return String.Empty;
        }

        private static string GetBoundsString(GeographicBounds bounds)
        {
            if (bounds != null)
            {
                return String.Format("&bounds={0},{1}|{2},{3}", bounds.SouthWest.Latitude, bounds.SouthWest.Longitude, bounds.NorthEast.Latitude, bounds.NorthEast.Longitude);
            }
            return String.Empty;
        }
    }
}