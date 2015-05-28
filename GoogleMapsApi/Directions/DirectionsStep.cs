using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/directions/#Steps
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class DirectionsStep
    {
        /// <summary>
        /// Contains formatted instructions for this step, presented as an HTML text string.
        /// </summary>
        [JsonProperty("html_instructions")]
        public string EndAddress { get; set; }

        /// <summary>
        /// The distance covered by this step. This property may be undefined as the distance may be unknown.
        /// </summary>
        [JsonProperty("distance")]
        public DirectionsDistance Distance { get; set; }

        /// <summary>
        /// The total duration of this step. This property may be undefined as the duration may be unknown.
        /// </summary>
        [JsonProperty("duration")]
        public DirectionsDuration Duration { get; set; }

        /// <summary>
        /// The ending location of this step.
        /// </summary>
        [JsonProperty("end_location")]
        public GeographicLocation EndLocation { get; set; }

        /// <summary>
        /// The starting location of this step.
        /// </summary>
        [JsonProperty("start_location")]
        public GeographicLocation StartLocation { get; set; }

        /// <summary>
        /// The mode of travel used in this step.
        /// </summary>
        [JsonProperty("travel_mode")]
        public DirectionsTravelMode TravelMode { get; set; }

        /// <summary>
        /// A sequence of LatLngs describing the course of this step.
        /// </summary>
        [JsonProperty("polyline")]
        public EncodedPolyline Polyline { get; set; }
    }
}