using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public class Circle : ICircle
    {
        private IGoogleMapHost _host;

        public event Action<ICircle, GeographicLocation> Click;
        public event Action<ICircle, GeographicLocation> RightClick;
        public event Action<ICircle, GeographicLocation> DoubleClick;

        public int CircleId { get; private set; }

        public GeographicLocation Position
        {
            get
            {
                var jsonLocation = _host.InvokeScript("getJSONCirclePosition", CircleId);
                return JsonConvert.DeserializeObject<GeographicLocation>(jsonLocation.ToString());
            }
        }

        public double Radius
        {
            get
            {
                return (double)_host.InvokeScript("getCircleRadius", CircleId);
            }
        }

        public bool Visible
        {
            get 
            {
                return (bool)_host.InvokeScript("getCircleVisibility", CircleId);
            }
            set
            {
                _host.InvokeScript("setCircleVisibility", CircleId, value);
            }
        }

        public bool Editable
        {
            get
            {
                return (bool)_host.InvokeScript("getCircleEditable", CircleId);
            }
            set
            {
                _host.InvokeScript("setCircleEditable", CircleId, value);
            }
        }

        internal Circle(IGoogleMapHost host, int circleId)
        {
            CircleId = circleId;
            _host = host;
        }

        internal void FireCircleClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FireCircleRightClick(GeographicLocation location)
        {
            if (RightClick != null)
            {
                RightClick(this, location);
            }
        }

        internal void FireCircleDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }
    }
}