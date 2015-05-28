using System;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    public class InfoWindow : IInfoWindow
    {
        private IGoogleMapHost _host;

        public event Action<IInfoWindow> CloseClick;

        public int InfoWindowID { get; private set; }

        internal InfoWindow(IGoogleMapHost host, int infoWindowId)
        {
            InfoWindowID = infoWindowId;
            _host = host;
        }

        public void Close()
        {
            _host.InvokeScript("closeInfoWindow", InfoWindowID);
        }

        internal void FireCloseClick()
        {
            if (CloseClick != null)
            {
                CloseClick(this);
            }
        }
    }
}