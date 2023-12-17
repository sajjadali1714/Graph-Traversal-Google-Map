using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void loadMap(GMapControl Map, double latitude, double longitude, bool addMarker)
        {
            try
            {
                Map.ShowCenter = false;
                Map.DragButton = MouseButtons.Left;
                Map.MapProvider = GMapProviders.GoogleMap;
                Map.Position = new GMap.NET.PointLatLng(latitude, longitude);
                Map.MinZoom = 1;
                Map.MaxZoom = 22;
                Map.Zoom = 13;

                if (addMarker == true)
                {


                    PointLatLng point = new GMap.NET.PointLatLng(latitude, longitude);
                    GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                    // Create Overlay
                    GMapOverlay markers = new GMapOverlay("markers");

                    // Add all markers to that overlay
                    markers.Markers.Add(marker);

                    // Cover map with overlay
                    Map.Overlays.Add(markers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetRoute(GMapControl Map, PointLatLng start, PointLatLng end, int zoom)
        {
            try
            {
                Map.MapProvider = GMapProviders.GoogleMap;

                Map.Position = start; // Set the map position to the starting point

                Map.MinZoom = 3;
                Map.MaxZoom = 18;
                Map.Zoom = zoom;

                // Create a route
                GMapRoute r = new GMapRoute(new List<PointLatLng> { start, end }, "My Route")
                {
                    Stroke = new Pen(Color.Red, 5)
                };

                GMapOverlay routes = new GMapOverlay("routes");
                routes.Routes.Add(r);

                Map.Overlays.Add(routes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




    }
}
