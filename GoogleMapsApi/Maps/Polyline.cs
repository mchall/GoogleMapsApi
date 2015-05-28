using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public class Polyline : IPolyline
    {
        private IGoogleMapHost _host;

        public event Action<IPolyline, GeographicLocation> Click;
        public event Action<IPolyline, GeographicLocation> RightClick;
        public event Action<IPolyline, GeographicLocation> DoubleClick;

        public int PolylineId { get; private set; }

        public List<GeographicLocation> Paths
        {
            get
            {
                var jsonPaths = _host.InvokeScript("getJSONPolylinePath", PolylineId);
                return JsonConvert.DeserializeObject<List<GeographicLocation>>(jsonPaths.ToString());
            }
        }

        public bool Visible
        {
            get
            {
                return (bool)_host.InvokeScript("getPolylineVisibility", PolylineId);
            }
            set
            {
                _host.InvokeScript("setPolylineVisibility", PolylineId, value);
            }
        }

        public bool Editable
        {
            get
            {
                return (bool)_host.InvokeScript("getPolylineEditable", PolylineId);
            }
            set
            {
                _host.InvokeScript("setPolylineEditable", PolylineId, value);
            }
        }

        internal Polyline(IGoogleMapHost host, int polylineId)
        {
            PolylineId = polylineId;
            _host = host;
        }

        internal void FirePolylineClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FirePolylineRightClick(GeographicLocation location)
        {
            if (RightClick != null)
            {
                RightClick(this, location);
            }
        }

        internal void FirePolylineDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }
    }
}