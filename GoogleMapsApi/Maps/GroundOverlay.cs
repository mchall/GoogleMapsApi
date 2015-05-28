using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace GoogleMapsApi
{
    public class GroundOverlay : IGroundOverlay
    {
        private IGoogleMapHost _host;

        public event Action<IGroundOverlay, GeographicLocation> Click;
        public event Action<IGroundOverlay, GeographicLocation> DoubleClick;

        public int GroundOverlayId { get; private set; }

        public double Opacity
        {
            get
            {
                return (double)_host.InvokeScript("getGroundOverlayOpacity", GroundOverlayId);
            }
            set
            {
                _host.InvokeScript("setGroundOverlayOpacity", GroundOverlayId, value);
            }
        }

        internal GroundOverlay(IGoogleMapHost host, int groundOverlayId)
        {
            GroundOverlayId = groundOverlayId;
            _host = host;
        }

        internal void FireGroundOverlayClick(GeographicLocation location)
        {
            if (Click != null)
            {
                Click(this, location);
            }
        }

        internal void FireGroundOverlayDoubleClick(GeographicLocation location)
        {
            if (DoubleClick != null)
            {
                DoubleClick(this, location);
            }
        }
    }
}