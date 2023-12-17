using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project.Classes
{
    public class GoogleMap
    {
        public GoogleMap()
        {

        }

        public void loadMap(GMapControl Map, double latitude, double longitude)
        {
            try
            {
                Map.ShowCenter = false;
                Map.DragButton = MouseButtons.Left;
                Map.MapProvider = GMapProviders.GoogleMap;
                Map.Position = new GMap.NET.PointLatLng(latitude, longitude);
                Map.MinZoom = 1;
                Map.MaxZoom = 22;
                Map.Zoom = 18;


                PointLatLng point = new GMap.NET.PointLatLng(latitude, longitude);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                // Create Overlay
                GMapOverlay markers = new GMapOverlay("markers");

                // Add all markers to that overlay
                markers.Markers.Add(marker);

                // Cover map with overlay
                Map.Overlays.Add(markers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void getRoute(GMapControl Map, PointLatLng start, PointLatLng end, int zoom)
        {
            try
            {
                Map.MapProvider = GMapProviders.GoogleMap;
                GDirections gd = null;
                DirectionsStatusCode Res = Map.DirectionsProvider.GetDirections(out gd, Map.Position, new PointLatLng(54.7261334816182, 25.2985095977783), false, false, false, false, true);

                if (Res == DirectionsStatusCode.OK)
                {
                    var route = GoogleMapProvider.Instance.GetRoute(start, end, false, false, zoom);

                    if (route != null && route.Status == RouteStatusCode.OK)
                    {
                        var r = new GMapRoute(route.Points, "My Route")
                        {
                            Stroke = new Pen(Color.Red, 5)
                        };

                        GMapOverlay routes = new GMapOverlay("routes");
                        routes.Routes.Add(r);
                        Map.Overlays.Add(routes);
                    }
                    else
                    {
                        MessageBox.Show("Failed to get route. Status: " + route?.Status);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
