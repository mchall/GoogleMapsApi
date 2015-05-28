using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/directions/#DirectionsRequests
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsRequest
    {
        public DirectionsTravelMode TravelMode { get; set; }

        public List<string> WayPoints { get; set; }

        public bool Alternatives { get; set; }

        public string Region { get; set; }

        public DirectionsUnitSystem Unit { get; set; }

        public bool AvoidTolls { get; set; }

        public bool AvoidHighways { get; set; }

        public bool Sensor { get; set; }

        public DirectionsRequest()
        {
            TravelMode = DirectionsTravelMode.Driving;
            Unit = DirectionsUnitSystem.Metric;
            WayPoints = new List<string>();
        }
    }
}