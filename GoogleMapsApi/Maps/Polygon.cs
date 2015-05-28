using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public class Polygon : IPolygon
    {
        private IGoogleMapHost _host;

        public event Action<IPolygon, GeographicLocation> Click;
        public event Action<IPolygon, GeographicLocation> RightClick;
        public event Action<IPolygon, GeographicLocation> DoubleClick;

        public int PolygonId { get; private set; }

        public List<GeographicLocation> Paths
        {
            get 
            {
                var jsonPaths = _host.InvokeScript("getJSONPolygonPaths", PolygonId);
                return JsonConvert.DeserializeObject<List<GeographicLocation>>(jsonPaths.ToString());
            }
        }

        public bool Visible
        {
            get
            {
                return (bool)_host.InvokeScript("getPolygonVisibility", PolygonId);
            }
            set
            {
                _host.InvokeScript("setPolygonVisibility", PolygonId, value);
            }
        }

        public bool Editable
        {
            get
            {
                return (bool)_host.InvokeScript("getPolygonEditable", PolygonId);
            }
            set
            {
                _host.InvokeScript("setPolygonEditable", PolygonId, value);
            }
        }

        internal Polygon(IGoogleMapHost host, int polygonId)
        {
            PolygonId = polygonId;
            _host = host;
        }

        internal void FirePolygonClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FirePolygonRightClick(GeographicLocation location)
        {
            if (RightClick != null)
            {
                RightClick(this, location);
            }
        }

        internal void FirePolygonDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }
    }
}