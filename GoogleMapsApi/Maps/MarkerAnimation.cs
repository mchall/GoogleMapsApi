using System;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#Animation
    /// </summary>
    public enum MarkerAnimation
    {
        /// <summary>
        /// Marker bounces until animation is stopped.
        /// </summary>
        Bounce = 1,

        /// <summary>
        /// Marker falls from the top of the map ending with a small bounce.
        /// </summary>
        Drop = 2,
    }
}