using System;

namespace GoogleMapsApi
{
    public interface IInfoWindow
    {
        /// <summary>
        /// This event is fired when the close button was clicked.
        /// </summary>
        event Action<IInfoWindow> CloseClick;

        /// <summary>
        /// The ID of the info window
        /// </summary>
        int InfoWindowID { get; }

        /// <summary>
        /// Closes this InfoWindow by removing it from the DOM structure.
        /// </summary>
        void Close();
    }
}