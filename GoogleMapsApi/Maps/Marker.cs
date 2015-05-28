using System;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    public class Marker : IMarker
    {
        private IGoogleMapHost _host;

        public event Action<IMarker, GeographicLocation> Click;
        public event Action<IMarker, GeographicLocation> RightClick;
        public event Action<IMarker, GeographicLocation> DoubleClick;
        public event Action<IMarker, GeographicLocation> DragEnd;

        public int MarkerId { get; private set; }

        public GeographicLocation Position
        {
            get
            {
                var jsonPosition = _host.InvokeScript("getJSONMarkerPosition", MarkerId);
                return JsonConvert.DeserializeObject<GeographicLocation>(jsonPosition.ToString());
            }
        }

        public bool Visible
        {
            get
            {
                return (bool)_host.InvokeScript("getMarkerVisibility", MarkerId);
            }
            set
            {
                _host.InvokeScript("setMarkerVisibility", MarkerId, value);
            }
        }

        internal Marker(IGoogleMapHost host, int markerId)
        {
            MarkerId = markerId;
            _host = host;
        }

        public void PlayAnimation(MarkerAnimation? animation)
        {
            _host.InvokeScript("setMarkerAnimation", MarkerId, animation.HasValue ? (int)animation : 0);
        }

        internal void FireMarkerClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FireMarkerRightClick(GeographicLocation location)
        {
            if (RightClick != null)
            {
                RightClick(this, location);
            }
        }

        internal void FireMarkerDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }

        internal void FireMarkerDragEnd(GeographicLocation location)
        {
            if (DragEnd != null)
            {
                DragEnd(this, location);
            }
        }
    }
}