using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public void loadMap(GMapControl Map, int zoom)
        {
            try
            {
                Map.ShowCenter = false;
                Map.DragButton = MouseButtons.Left;
                Map.MapProvider = GMapProviders.GoogleMap;
                Map.Position = new GMap.NET.PointLatLng(24.8978, 67.0799);
                Map.MinZoom = 1;
                Map.MaxZoom = 22;
                Map.Zoom = 13;                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void addMarker(GMapControl Map, List<PointLatLng> points)
        {
            try
            {


                PointLatLng point = new GMap.NET.PointLatLng(points[points.Count - 1].Lat, points[points.Count - 1].Lng);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_dot);

                // Create Overlay
                GMapOverlay markers = new GMapOverlay("markers");

                // Add all markers to that overlay
                markers.Markers.Add(marker);

                // Cover map with overlay
                Map.Overlays.Add(markers);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void GetRoute(GMapControl Map, List<PointLatLng> points, int zoom)
        {
            try
            {
                Map.MapProvider = GMapProviders.GoogleMap;

                Map.Position = points[points.Count - 1]; // Set the map position to the starting point

                Map.MinZoom = 3;
                Map.MaxZoom = 18;
                Map.Zoom = zoom;

                // Create a route
                
                GMapRoute r = new GMapRoute(points, "My Route")
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


        public void GetPolygon(GMapControl Map, List<PointLatLng> points, String name)
        {
            try
            {
                var polygon = new GMapPolygon(points, name)
                {
                    Stroke = new Pen(Color.DarkGreen, 2),
                };
                var polygons = new GMapOverlay("polygon");
                polygons.Polygons.Add(polygon);
                Map.Overlays.Add(polygons);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }













    }
}
