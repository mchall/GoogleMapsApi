using System;
using System.Text;

namespace GoogleMapsApi
{
    public class DirectionsService
    {
        public static readonly Uri ApiUrl = new Uri("https://maps.googleapis.com/maps/api/directions/");

        public static DirectionsResponse GetResponse(string origin, string destination, DirectionsRequest additional)
        {
            var url = new Uri(String.Format("{0}json?origin={1}&destination={2}{3}{4}{5}{6}{7}{8}{9}",
                ApiUrl,
                Http.UrlEncoding(origin),
                Http.UrlEncoding(destination),
                GetSensorString(additional),
                GetWaypointString(additional),
                GetUnitString(additional),
                GetAvoidString(additional),
                GetRegionString(additional),
                GetAlternativesString(additional),
                GetModeString(additional)
                ));
            return Http.Get(url).As<DirectionsResponse>();
        }

        private static string GetWaypointString(DirectionsRequest additional)
        {
            if (additional.WayPoints.Count > 0)
            {
                StringBuilder sb = new StringBuilder("&waypoints=");
                foreach (var s in additional.WayPoints)
                {
                    sb.Append(s);
                    sb.Append("|");
                }
                return sb.ToString();
            }
            return String.Empty;
        }

        private static string GetUnitString(DirectionsRequest additional)
        {
            return String.Format("&units={0}", additional.Unit.ToString());
        }

        private static string GetAvoidString(DirectionsRequest additional)
        {
            StringBuilder sb = new StringBuilder();
            if (additional.AvoidHighways)
            {
                sb.Append("&avoid=highways");
            }
            if (additional.AvoidTolls)
            {
                sb.Append("&avoid=tolls");
            }
            return sb.ToString();
        }

        private static string GetRegionString(DirectionsRequest additional)
        {
            if (String.IsNullOrEmpty(additional.Region))
                return String.Empty;
            return String.Format("&region=", additional.Region);
        }

        private static string GetSensorString(DirectionsRequest additional)
        {
            return String.Format("&sensor={0}", additional.Sensor ? "true" : "false");
        }

        private static string GetAlternativesString(DirectionsRequest additional)
        {
            if (additional.Alternatives)
            {
                return "&alternatives=true";
            }
            return String.Empty;
        }

        private static string GetModeString(DirectionsRequest additional)
        {
            return String.Format("&mode={0}", additional.TravelMode.ToString());
        }
    }
}