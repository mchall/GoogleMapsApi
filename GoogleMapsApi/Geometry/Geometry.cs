using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    public class Geometry : IGeometry
    {
        private IGoogleMapHost _host;

        public Geometry(IGoogleMapHost host)
        {
            _host = host;
        }

        public List<GeographicLocation> DecodePolyline(EncodedPolyline polyline)
        {
            string jsonLocations = (string)_host.InvokeScript("decodePathString", polyline.EncodedPoints);
            return JsonConvert.DeserializeObject<List<GeographicLocation>>(jsonLocations);
        }

        public bool ContainsLocation(IPolygon polygon, GeographicLocation location)
        {
            return (bool)_host.InvokeScript("containsLocation", location.Latitude, location.Longitude, polygon.PolygonId);
        }

        public bool IsLocationOnEdge(IPolygon polygon, GeographicLocation location, double? tolerance)
        {
            return (bool)_host.InvokeScript("isLocationOnEdge", location.Latitude, location.Longitude, polygon.PolygonId, true, tolerance);
        }

        public bool IsLocationOnEdge(IPolyline polyline, GeographicLocation location, double? tolerance)
        {
            return (bool)_host.InvokeScript("isLocationOnEdge", location.Latitude, location.Longitude, polyline.PolylineId, false, tolerance);
        }

        public double ComputeArea(List<GeographicLocation> locations)
        {
            string jsonLocations = JsonConvert.SerializeObject(locations);
            return (double)_host.InvokeScript("computeArea", jsonLocations);
        }

        public double ComputeDistanceBetween(GeographicLocation from, GeographicLocation to)
        {
            string jsonFrom = JsonConvert.SerializeObject(from);
            string jsonTo = JsonConvert.SerializeObject(to);
            return (double)_host.InvokeScript("computeDistanceBetween", jsonFrom, jsonTo);
        }

        public double ComputeHeading(GeographicLocation from, GeographicLocation to)
        {
            string jsonFrom = JsonConvert.SerializeObject(from);
            string jsonTo = JsonConvert.SerializeObject(to);
            return (double)_host.InvokeScript("computeHeading", jsonFrom, jsonTo);
        }

        public double ComputeLength(List<GeographicLocation> locations)
        {
            string jsonLocations = JsonConvert.SerializeObject(locations);
            return (double)_host.InvokeScript("computeLength", jsonLocations);
        }

        public GeographicLocation ComputeOffset(GeographicLocation from, double distance, double heading)
        {
            string jsonFrom = JsonConvert.SerializeObject(from);
            var result = (string)_host.InvokeScript("computeOffset", jsonFrom, distance, heading);
            return JsonConvert.DeserializeObject<GeographicLocation>(result);
        }

        public GeographicLocation Interpolate(GeographicLocation from, GeographicLocation to, double fraction)
        {
            string jsonFrom = JsonConvert.SerializeObject(from);
            string jsonTo = JsonConvert.SerializeObject(to);
            var result = (string)_host.InvokeScript("interpolate", jsonFrom, jsonTo, fraction);
            return JsonConvert.DeserializeObject<GeographicLocation>(result);
        }
    }
}