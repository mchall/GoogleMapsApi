using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public class Rectangle : IRectangle
    {
        private IGoogleMapHost _host;

        public event Action<IRectangle, GeographicLocation> Click;
        public event Action<IRectangle, GeographicLocation> RightClick;
        public event Action<IRectangle, GeographicLocation> DoubleClick;

        public int RectangleId { get; private set; }

        public GeographicBounds Bounds
        {
            get
            {
                var jsonBounds = _host.InvokeScript("getJSONRectangleBounds", RectangleId);
                return JsonConvert.DeserializeObject<GeographicBounds>(jsonBounds.ToString());
            }
        }

        public bool Visible
        {
            get
            {
                return (bool)_host.InvokeScript("getRectangleVisibility", RectangleId);
            }
            set
            {
                _host.InvokeScript("setRectangleVisibility", RectangleId, value);
            }
        }

        public bool Editable
        {
            get
            {
                return (bool)_host.InvokeScript("getRectangleEditable", RectangleId);
            }
            set
            {
                _host.InvokeScript("setRectangleEditable", RectangleId, value);
            }
        }

        internal Rectangle(IGoogleMapHost host, int rectangleId)
        {
            RectangleId = rectangleId;
            _host = host;
        }

        internal void FireRectangleClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FireRectangleRightClick(GeographicLocation location)
        {
            if (RightClick != null)
            {
                RightClick(this, location);
            }
        }

        internal void FireRectangleDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }
    }
}