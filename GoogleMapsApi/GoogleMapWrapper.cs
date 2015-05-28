using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using Newtonsoft.Json;

namespace GoogleMapsApi
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [ComVisibleAttribute(true)]
    public class GoogleMapWrapper : IGoogleMapWrapper, IGoogleMapRequired
    {
        /// <summary>
        /// Creates a new Google Map
        /// </summary>
        /// <param name="host">Browser host to host Google Maps in</param>
        /// <returns>Interface to interact with Google Maps</returns>
        public static IGoogleMapWrapper Create(IGoogleMapHost host)
        {
            return new GoogleMapWrapper(host, new MapOptions(), new StreetViewOptions());
        }

        /// <summary>
        /// Creates a new Google Map
        /// </summary>
        /// <param name="host">Browser host to host Google Maps i</param>
        /// <param name="mapOptions">Customize the look of the map</param>
        /// <param name="streetViewOptions">Customize the look of the street view panormama</param>
        /// <param name="apiKey">API key (Optional, but if required visit this site: "https://code.google.com/apis/console/")</param>
        /// <param name="sensor">Whether calling from a sensor. Defaults to false.</param>
        /// <param name="regionString">Country code (ie. "za"). Defaults to NULL</param>
        /// <returns>Interface to interact with Google Maps</returns>
        public static IGoogleMapWrapper Create(IGoogleMapHost host, MapOptions mapOptions, StreetViewOptions streetViewOptions, string apiKey = null, bool sensor = false, string regionString = null)
        {
            return new GoogleMapWrapper(host, mapOptions, streetViewOptions, apiKey, sensor, regionString);
        }

        private StreetView _streetView;
        private IGoogleMapHost _browser;
        private bool _documentLoaded;
        private MapOptions _mapOptions;
        private StreetViewOptions _streetViewOptions;
        private Geometry _geometry;

        private Dictionary<int, Marker> _markers;
        private Dictionary<int, Polygon> _polygons;
        private Dictionary<int, Circle> _circles;
        private Dictionary<int, InfoWindow> _infoWindows;
        private Dictionary<int, Polyline> _polylines;
        private Dictionary<int, GroundOverlay> _groundOverlays;
        private Dictionary<int, Rectangle> _rectangles;

        public event Action<GeographicLocation> MapClick;
        public event Action<GeographicLocation> MapRightClick;
        public event Action<GeographicLocation> MapDoubleClick;
        public event Action<int> ZoomChanged;
        public event Action<GeographicLocation> CenterChanged;
        public event Action<GeographicBounds> BoundsChanged;
        public event Action MapResized;
        public event Action MapDragStart;
        public event Action MapDragEnd;
        public event Action ApiReady;

        public string ApiKey { get; private set; }
        public bool Sensor { get; private set; }
        public string RegionString { get; private set; }

        public IStreetView StreetView
        {
            get { return _streetView; }
        }

        public IGeometry Geometry
        {
            get { return _geometry; }
        }

        public MapOptions MapOptions
        {
            get { return _mapOptions; }
        }

        private GeographicLocation _center;
        public GeographicLocation Center
        {
            get
            {
                return _center;
            }
            set
            {
                _center = value;
                if (_documentLoaded)
                {
                    _browser.InvokeScript("setCenter", value.Latitude, value.Longitude);
                }
            }
        }

        private int _zoom;
        public int Zoom
        {
            get
            {
                return _zoom;
            }
            set
            {
                _zoom = value;
                if (_documentLoaded)
                {
                    _browser.InvokeScript("setZoom", value);
                }
            }
        }

        internal GoogleMapWrapper(IGoogleMapHost browser, MapOptions mapOptions, StreetViewOptions streetViewOptions, string apiKey = null, bool sensor = false, string regionString = null)
        {
            _markers = new Dictionary<int, Marker>();
            _polygons = new Dictionary<int, Polygon>();
            _circles = new Dictionary<int, Circle>();
            _infoWindows = new Dictionary<int, InfoWindow>();
            _polylines = new Dictionary<int, Polyline>();
            _groundOverlays = new Dictionary<int, GroundOverlay>();
            _rectangles = new Dictionary<int, Rectangle>();

            _browser = browser;

            ApiKey = apiKey;
            Sensor = sensor;
            RegionString = regionString;

            _mapOptions = mapOptions;
            _streetViewOptions = streetViewOptions;
            _zoom = mapOptions.Zoom;
            _center = mapOptions.Center;

            StringBuilder documentBuilder = new StringBuilder();
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format("{0}.Map.html", this.GetType().Namespace)))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        documentBuilder.AppendLine(line);

                        if (line == "<head>")
                        {
                            //Inject JQuery scripts
                            documentBuilder.AppendLine(GetScriptText());
                        }
                    }
                }
            }
            _browser.SetHostDocumentText(documentBuilder.ToString());
            _browser.RegisterScriptingObject(this);
            _documentLoaded = true;
            _streetView = new StreetView(_browser);
            _geometry = new Geometry(_browser);
        }

        private string GetScriptText()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<script type=\"text/javascript\">");
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format("{0}.js.jquery.min.js", this.GetType().Namespace)))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    sb.AppendLine(reader.ReadToEnd());
                }
            }
            sb.AppendLine("</script>");

            sb.AppendLine("<script type=\"text/javascript\">");
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(String.Format("{0}.js.jquery.json-2.3.min.js", this.GetType().Namespace)))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    sb.AppendLine(reader.ReadToEnd());
                }
            }
            sb.AppendLine("</script>");

            return sb.ToString();
        }

        public void UpdateMapOptions()
        {
            if (_documentLoaded)
            {
                _browser.InvokeScript("updateMapOptions");
            }
        }

        public void FitToBounds(GeographicBounds bounds)
        {
            string jsonSouthWest = JsonConvert.SerializeObject(bounds.SouthWest);
            string jsonNorthEast = JsonConvert.SerializeObject(bounds.NorthEast);
            _browser.InvokeScript("fitBounds", jsonSouthWest, jsonNorthEast);
        }

        public IInfoWindow ShowInfoWindow(string contentString, GeographicLocation location, InfoWindowOptions infoWindowOptions, bool hideOthers = false)
        {
            string jsonLocation = JsonConvert.SerializeObject(location);
            string jsonInfoWindowOptions = JsonConvert.SerializeObject(infoWindowOptions);
            int infoWindowId = (int)_browser.InvokeScript("showInfoWindow", contentString, jsonLocation, null, jsonInfoWindowOptions, hideOthers, false);

            _infoWindows[infoWindowId] = new InfoWindow(_browser, infoWindowId);
            return _infoWindows[infoWindowId];
        }

        public IInfoWindow ShowInfoWindow(string contentString, IMarker marker, InfoWindowOptions infoWindowOptions, bool hideOthers = false)
        {
            string jsonInfoWindowOptions = JsonConvert.SerializeObject(infoWindowOptions);
            int infoWindowId = (int)_browser.InvokeScript("showInfoWindow", contentString, null, marker.MarkerId, jsonInfoWindowOptions, hideOthers, false);

            _infoWindows[infoWindowId] = new InfoWindow(_browser, infoWindowId);
            return _infoWindows[infoWindowId];
        }

        public IPolygon DrawPolygon(List<GeographicLocation> locations, PolygonOptions polygonOptions, bool hideOthers = false)
        {
            string jsonLocations = JsonConvert.SerializeObject(locations);
            string jsonPolygonOptions = JsonConvert.SerializeObject(polygonOptions);
            int polygonId = (int)_browser.InvokeScript("drawPolygon", jsonLocations, jsonPolygonOptions, hideOthers);

            _polygons[polygonId] = new Polygon(_browser, polygonId);
            return _polygons[polygonId];
        }

        public IPolyline DrawPolyline(List<GeographicLocation> locations, PolylineOptions polylineOptions, bool hideOthers = false)
        {
            string jsonLocations = JsonConvert.SerializeObject(locations);
            string jsonPolylineOptions = JsonConvert.SerializeObject(polylineOptions);
            int polylineId = (int)_browser.InvokeScript("drawPolyline", jsonLocations, jsonPolylineOptions, hideOthers);

            _polylines[polylineId] = new Polyline(_browser, polylineId);
            return _polylines[polylineId];
        }

        public ICircle DrawCircle(GeographicLocation center, double radius, CircleOptions circleOptions, bool hideOthers = false)
        {
            string jsonLocation = JsonConvert.SerializeObject(center);
            string jsonCircleOptions = JsonConvert.SerializeObject(circleOptions);
            int circleId = (int)_browser.InvokeScript("drawCircle", jsonLocation, radius, jsonCircleOptions, hideOthers);

            _circles[circleId] = new Circle(_browser, circleId);
            return _circles[circleId];
        }

        public IMarker AddMarker(GeographicLocation location, MarkerOptions markerOptions, bool hideOthers = false)
        {
            string jsonLocation = JsonConvert.SerializeObject(location);
            string jsonMarkerOptions = JsonConvert.SerializeObject(markerOptions);
            int markerId = (int)_browser.InvokeScript("addMarker", jsonLocation, jsonMarkerOptions, hideOthers, false);

            _markers[markerId] = new Marker(_browser, markerId);
            return _markers[markerId];
        }

        public IGroundOverlay AddGroundOverlay(string imageUrl, GeographicBounds bounds, GroundOverlayOptions groundOverlayOptions)
        {
            string jsonSW = JsonConvert.SerializeObject(bounds.SouthWest);
            string jsonNE = JsonConvert.SerializeObject(bounds.NorthEast);
            string jsonGroundOverlayOptions = JsonConvert.SerializeObject(groundOverlayOptions);
            int groundOverlayId = (int)_browser.InvokeScript("addGroundOverlay", imageUrl, jsonSW, jsonNE, jsonGroundOverlayOptions);

            _groundOverlays[groundOverlayId] = new GroundOverlay(_browser, groundOverlayId);
            return _groundOverlays[groundOverlayId];
        }

        public IRectangle DrawRectangle(GeographicBounds bounds, RectangleOptions rectangleOptions, bool hideOthers = false)
        {
            string jsonSW = JsonConvert.SerializeObject(bounds.SouthWest);
            string jsonNE = JsonConvert.SerializeObject(bounds.NorthEast);
            string jsonRectangleOptions = JsonConvert.SerializeObject(rectangleOptions);
            int rectangleId = (int)_browser.InvokeScript("addRectangle", jsonSW, jsonNE, jsonRectangleOptions, hideOthers);

            _rectangles[rectangleId] = new Rectangle(_browser, rectangleId);
            return _rectangles[rectangleId];
        }

        public GeocodingResponse RunGeocoder(string address, string region = null, GeographicBounds bounds = null)
        {
            return GeocodingService.GetResponse(address, region, bounds);
        }

        public GeocodingResponse RunGeocoder(GeographicLocation location)
        {
            return GeocodingService.GetResponse(location);
        }

        public DirectionsResponse RunDirections(string origin, string destination, DirectionsRequest additionalDetails)
        {
            return DirectionsService.GetResponse(origin, destination, additionalDetails);
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

            foreach (var polygon in _polygons.Values)
            {
                polygon.Visible = false;
            }

            foreach (var circle in _circles.Values)
            {
                circle.Visible = false;
            }

            foreach (var polyline in _polylines.Values)
            {
                polyline.Visible = false;
            }

            foreach (var groundOverlay in _groundOverlays.Values)
            {
                groundOverlay.Opacity = 0;
            }
        }

        public void PanTo(GeographicLocation location)
        {
            string jsonLocation = JsonConvert.SerializeObject(location);
            _browser.InvokeScript("panToLocation", jsonLocation);
        }

        public void PanTo(GeographicBounds bounds)
        {
            string swBounds = JsonConvert.SerializeObject(bounds.SouthWest);
            string neBounds = JsonConvert.SerializeObject(bounds.NorthEast);
            _browser.InvokeScript("panToBounds", swBounds, neBounds);
        }

        public void PanBy(double x, double y)
        {
            _browser.InvokeScript("panBy", x, y);
        }

        #region IGoogleMapRequired members

        public bool HandleException(string message, string url, string line)
        {
            return _browser.HandleException(message, url, line);
        }

        public string MapUrl
        {
            get
            {
                return String.Format("https://maps.googleapis.com/maps/api/js?{0}&sensor={1}&callback=initialize{2}",
                                    String.IsNullOrEmpty(ApiKey) ? String.Empty : String.Format("key={0}", ApiKey),
                                    Sensor ? "true" : "false",
                                    String.IsNullOrEmpty(RegionString) ? String.Empty : String.Format("&region={0}", RegionString));
            }
        }

        public string GetJsonMapOptions()
        {
            return JsonConvert.SerializeObject(_mapOptions);
        }

        public string GetJsonPanoramaOptions()
        {
            return JsonConvert.SerializeObject(_streetViewOptions);
        }

        public void FireApiReady()
        {
            if (ApiReady != null)
            {
                ApiReady();
            }
        }

        public void FireMapClick(double latitude, double longitude)
        {
            if (MapClick != null)
            {
                MapClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMapRightClick(double latitude, double longitude)
        {
            if (MapRightClick != null)
            {
                MapRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMapDoubleClick(double latitude, double longitude)
        {
            if (MapDoubleClick != null)
            {
                MapDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMapCenterChanged(double latitude, double longitude)
        {
            _center = new GeographicLocation(latitude, longitude);
            if (CenterChanged != null)
            {
                CenterChanged(_center);
            }
        }

        public void FireMapBoundsChanged(double latitudeSW, double longitudeSW, double latitudeNE, double longitudeNE)
        {
            if (BoundsChanged != null)
            {
                BoundsChanged(new GeographicBounds()
                {
                    SouthWest = new GeographicLocation(latitudeSW, longitudeSW),
                    NorthEast = new GeographicLocation(latitudeNE, longitudeNE),
                });
            }
        }

        public void FireZoomChanged(int zoom)
        {
            _zoom = zoom;
            if (ZoomChanged != null)
            {
                ZoomChanged(_zoom);
            }
        }

        public void FireMapResized()
        {
            if (MapResized != null)
            {
                MapResized();
            }
        }

        public void FireDragStart()
        {
            if (MapDragStart != null)
            {
                MapDragStart();
            }
        }

        public void FireDragEnd()
        {
            if (MapDragEnd != null)
            {
                MapDragEnd();
            }
        }

        public void FireStreetViewPositionChanged()
        {
            if (_streetView != null)
            {
                _streetView.FirePositionChanged();
            }
        }

        public void FireStreetViewPOVChanged()
        {
            if (_streetView != null)
            {
                _streetView.FirePOVChanged();
            }
        }

        public void FireStreetViewVisibleChanged()
        {
            if (_streetView != null)
            {
                _streetView.FireVisibleChanged();
            }
        }

        public void FireMarkerClick(int markerId, double latitude, double longitude)
        {
            if (_markers.ContainsKey(markerId))
            {
                _markers[markerId].FireMarkerClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMarkerDoubleClick(int markerId, double latitude, double longitude)
        {
            if (_markers.ContainsKey(markerId))
            {
                _markers[markerId].FireMarkerDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMarkerRightClick(int markerId, double latitude, double longitude)
        {
            if (_markers.ContainsKey(markerId))
            {
                _markers[markerId].FireMarkerRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireMarkerDragEnd(int markerId, double latitude, double longitude)
        {
            if (_markers.ContainsKey(markerId))
            {
                _markers[markerId].FireMarkerDragEnd(new GeographicLocation(latitude, longitude));
            }
        }
       
        public void FirePolygonClick(int polygonId, double latitude, double longitude)
        {
            if (_polygons.ContainsKey(polygonId))
            {
                _polygons[polygonId].FirePolygonClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FirePolygonDoubleClick(int polygonId, double latitude, double longitude)
        {
            if (_polygons.ContainsKey(polygonId))
            {
                _polygons[polygonId].FirePolygonDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FirePolygonRightClick(int polygonId, double latitude, double longitude)
        {
            if (_polygons.ContainsKey(polygonId))
            {
                _polygons[polygonId].FirePolygonRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireCircleClick(int circleId, double latitude, double longitude)
        {
            if (_circles.ContainsKey(circleId))
            {
                _circles[circleId].FireCircleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireCircleDoubleClick(int circleId, double latitude, double longitude)
        {
            if (_circles.ContainsKey(circleId))
            {
                _circles[circleId].FireCircleDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireCircleRightClick(int circleId, double latitude, double longitude)
        {
            if (_circles.ContainsKey(circleId))
            {
                _circles[circleId].FireCircleRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireInfoWindowCloseClick(int infoWindowId)
        {
            if (_infoWindows.ContainsKey(infoWindowId))
            {
                _infoWindows[infoWindowId].FireCloseClick();
            }
        }

        public void FirePolylineClick(int polylineId, double latitude, double longitude)
        {
            if (_polylines.ContainsKey(polylineId))
            {
                _polylines[polylineId].FirePolylineClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FirePolylineDoubleClick(int polylineId, double latitude, double longitude)
        {
            if (_polylines.ContainsKey(polylineId))
            {
                _polylines[polylineId].FirePolylineDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FirePolylineRightClick(int polylineId, double latitude, double longitude)
        {
            if (_polylines.ContainsKey(polylineId))
            {
                _polylines[polylineId].FirePolylineRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireGroundOverlayClick(int groundOverlayId, double latitude, double longitude)
        {
            if (_groundOverlays.ContainsKey(groundOverlayId))
            {
                _groundOverlays[groundOverlayId].FireGroundOverlayClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireGroundOverlayDoubleClick(int groundOverlayId, double latitude, double longitude)
        {
            if (_groundOverlays.ContainsKey(groundOverlayId))
            {
                _groundOverlays[groundOverlayId].FireGroundOverlayDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireRectangleClick(int rectangleId, double latitude, double longitude)
        {
            if (_rectangles.ContainsKey(rectangleId))
            {
                _rectangles[rectangleId].FireRectangleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireRectangleDoubleClick(int rectangleId, double latitude, double longitude)
        {
            if (_rectangles.ContainsKey(rectangleId))
            {
                _rectangles[rectangleId].FireRectangleDoubleClick(new GeographicLocation(latitude, longitude));
            }
        }

        public void FireRectangleRightClick(int rectangleId, double latitude, double longitude)
        {
            if (_rectangles.ContainsKey(rectangleId))
            {
                _rectangles[rectangleId].FireRectangleRightClick(new GeographicLocation(latitude, longitude));
            }
        }

        #endregion
    }
}