using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    /// <summary>
    /// https://developers.google.com/maps/documentation/javascript/reference#StreetViewPanorama
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class StreetView : IStreetView
    {
        private Dictionary<int, Marker> _markers;
        private Dictionary<int, InfoWindow> _infoWindows;
        private IGoogleMapHost _host;

        public event Action<IStreetView, GeographicLocation> PositionChanged;
        public event Action<IStreetView, POV> POVChanged;
        public event Action<IStreetView, bool> VisibleChanged;

        public GeographicLocation Position
        {
            get
            {
                var jsonLocation = _host.InvokeScript("getJSONStreetViewPosition");
                return JsonConvert.DeserializeObject<GeographicLocation>(jsonLocation.ToString());
            }
            set
            {
                _host.InvokeScript("setStreetViewPosition", value.Latitude, value.Longitude);
            }
        }

        public POV POV
        {
            get
            {
                var jsonPOV = _host.InvokeScript("getJSONStreetViewPOV");
                return JsonConvert.DeserializeObject<POV>(jsonPOV.ToString());
            }
            set
            {
                _host.InvokeScript("setStreetViewPOV", JsonConvert.SerializeObject(value));
            }
        }

        public bool Visible
        {
            get
            {
                return (bool)_host.InvokeScript("getStreetViewVisibility");
            }
            set
            {
                _host.InvokeScript("setStreetViewVisibility", value);
            }
        }

        public StreetView(IGoogleMapHost host)
        {
            _host = host;
            _markers = new Dictionary<int, Marker>();
            _infoWindows = new Dictionary<int, InfoWindow>();
        }

        internal void FirePositionChanged()
        {
            if (PositionChanged != null)
            {
                PositionChanged(this, Position);
            }
        }

        internal void FirePOVChanged()
        {
            if (POVChanged != null)
            {
                POVChanged(this, POV);
            }
        }

        internal void FireVisibleChanged()
        {
            if (VisibleChanged != null)
            {
                VisibleChanged(this, Visible);
            }
        }

        public IInfoWindow ShowInfoWindow(string contentString, GeographicLocation location, InfoWindowOptions infoWindowOptions, bool hideOthers = false)
        {
            string jsonLocation = JsonConvert.SerializeObject(location);
            string jsonInfoWindowOptions = JsonConvert.SerializeObject(infoWindowOptions);
            int infoWindowId = (int)_host.InvokeScript("showInfoWindow", contentString, jsonLocation, null, jsonInfoWindowOptions, hideOthers, true);

            _infoWindows[infoWindowId] = new InfoWindow(_host, infoWindowId);
            return _infoWindows[infoWindowId];
        }

        public IInfoWindow ShowInfoWindow(string contentString, IMarker marker, InfoWindowOptions infoWindowOptions, bool hideOthers = false)
        {
            string jsonInfoWindowOptions = JsonConvert.SerializeObject(infoWindowOptions);
            int infoWindowId = (int)_host.InvokeScript("showInfoWindow", contentString, null, marker.MarkerId, jsonInfoWindowOptions, hideOthers, true);

            _infoWindows[infoWindowId] = new InfoWindow(_host, infoWindowId);
            return _infoWindows[infoWindowId];
        }

        public IMarker AddMarker(GeographicLocation location, MarkerOptions markerOptions, bool hideOthers = false)
        {
            string jsonLocation = JsonConvert.SerializeObject(location);
            string jsonMarkerOptions = JsonConvert.SerializeObject(markerOptions);
            int markerId = (int)_host.InvokeScript("addMarker", jsonLocation, jsonMarkerOptions, hideOthers, true);

            _markers[markerId] = new Marker(_host, markerId);
            return _markers[markerId];
        }

        public void Clean()
        {
            foreach (var marker in _markers.Values)
            {
                marker.Visible = false;
            }

            foreach (var window in _infoWindows.Values)
            {
                window.Close();
            }
        }
    }
}