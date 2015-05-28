using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoogleMapsApi
{
    public interface IGoogleMapRequired
    {
        string MapUrl { get; }

        string GetJsonMapOptions();
        string GetJsonPanoramaOptions();

        bool HandleException(string message, string url, string line);

        void FireApiReady();

        void FireMapClick(double latitude, double longitude);
        void FireMapRightClick(double latitude, double longitude);
        void FireMapDoubleClick(double latitude, double longitude);
        void FireMapCenterChanged(double latitude, double longitude);       
        void FireMapBoundsChanged(double latitudeSW, double longitudeSW, double latitudeNE, double longitudeNE);
        void FireZoomChanged(int zoom);
        void FireMapResized();
        void FireDragEnd();
        void FireDragStart();

        void FireStreetViewPositionChanged();
        void FireStreetViewPOVChanged();
        void FireStreetViewVisibleChanged();

        void FireMarkerClick(int markerId, double latitude, double longitude);
        void FireMarkerDoubleClick(int markerId, double latitude, double longitude);
        void FireMarkerRightClick(int markerId, double latitude, double longitude);
        void FireMarkerDragEnd(int markerId, double latitude, double longitude);

        void FirePolygonClick(int polygonId, double latitude, double longitude);
        void FirePolygonDoubleClick(int polygonId, double latitude, double longitude);
        void FirePolygonRightClick(int polygonId, double latitude, double longitude);

        void FireCircleClick(int circleId, double latitude, double longitude);
        void FireCircleDoubleClick(int circleId, double latitude, double longitude);
        void FireCircleRightClick(int circleId, double latitude, double longitude);

        void FirePolylineClick(int polylineId, double latitude, double longitude);
        void FirePolylineDoubleClick(int polylineId, double latitude, double longitude);
        void FirePolylineRightClick(int polylineId, double latitude, double longitude);

        void FireGroundOverlayClick(int groundOverlayId, double latitude, double longitude);
        void FireGroundOverlayDoubleClick(int groundOverlayId, double latitude, double longitude);

        void FireRectangleClick(int rectangleId, double latitude, double longitude);
        void FireRectangleDoubleClick(int rectangleId, double latitude, double longitude);
        void FireRectangleRightClick(int rectangleId, double latitude, double longitude);

        void FireInfoWindowCloseClick(int infoWindowId);
    }
}