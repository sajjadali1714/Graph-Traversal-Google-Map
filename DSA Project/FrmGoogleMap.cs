using DSA_Project.Classes;
using GMap.NET;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class FrmGoogleMap : Form
    {

        private List<PointLatLng> _points;
        private List<PointLatLng> _connectNodes;
        GoogleMap map = new GoogleMap();
        private int zoomLevel = 13;
        int count = 0;


        public FrmGoogleMap()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _connectNodes = new List<PointLatLng>();
            map.loadMap(GoogleMap, zoomLevel);
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            map.loadMap(GoogleMap, zoomLevel);
        }

        private void btnAdd(object sender, EventArgs e)
        {
            try
            {
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));
                map.addMarker(GoogleMap, _points);
                if (btnGet.Text == "Get Route")
                    map.GetRoute(GoogleMap, _points, zoomLevel);


                map.loadMap(GoogleMap, zoomLevel);
                txtOutput.Text = "Point Addedd : latitude " + txtLat.Text + " longitude " + txtLng.Text + Environment.NewLine + txtOutput.Text;
                txtLat.Text = String.Empty;
                txtLng.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGet.Text == "Get Route")
                {
                    if (_points.Count >= 2)
                    {
                        map.GetRoute(GoogleMap, _points, zoomLevel);
                        map.loadMap(GoogleMap, zoomLevel);
                        txtOutput.Text = "Route between : " + _points[0] + " and " + _points[1] + Environment.NewLine + txtOutput.Text;
                    }


                }
                else if (btnGet.Text == "Get Polygon")
                {
                    if (_points.Count >= 3)
                    {
                        map.GetPolygon(GoogleMap, _points, "My Area");
                        map.loadMap(GoogleMap, zoomLevel);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GoogleMap.Overlays.Clear();
            _points.Clear();
        }

        private void CmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtLat.Text = String.Empty;
                txtLng.Text = String.Empty;

                _points.Clear();
                if (CmbOptions.Text == "Generate Route")
                {
                    btnGet.Text = "Get Route";

                }
                else if (CmbOptions.Text == "Generate Polygon")
                {
                    btnGet.Text = "Get Polygon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void trackBar1_MouseLeave(object sender, EventArgs e)
        //{
        //    zoomLevel = tbZoom.Value; // Get the current value of the trackbar

        //    // Call your function to update the map with the new zoom level
        //    UpdateMapZoom(GoogleMap, zoomLevel);
        //}

        //private void UpdateMapZoom(GMapControl map, int zoom)
        //{
        //    try
        //    {
        //        // Set the map zoom level
        //        map.Zoom = zoom;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //}

        private void GoogleMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    var point = GoogleMap.FromLocalToLatLng(e.X, e.Y);
                    _points.Add(new PointLatLng(point.Lat, point.Lng));
                    map.addMarker(GoogleMap, _points);
                    map.loadMap(GoogleMap, zoomLevel);
                    txtOutput.Text = "Point Addedd : latitude " + point.Lat + " longitude " + point.Lng + Environment.NewLine + txtOutput.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void GoogleMap_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {


                if (GoogleMap.IsMouseOverMarker == true)
                {
                    
                    GMapMarker marker = GoogleMap.Overlays.SelectMany(overlay => overlay.Markers).FirstOrDefault(m => m.IsMouseOver);

                    if (marker != null)
                    {
                        // Access the Position property to get the latitude and longitude                        
                        txtOutput.Text = marker.Position.Lat + " - " + marker.Position.Lng + Environment.NewLine + txtOutput.Text;
                    }
                    var point = GoogleMap.FromLocalToLatLng(e.X, e.Y);

                    _connectNodes.Add(new PointLatLng(marker.Position.Lat, marker.Position.Lng));
                    count++;
                }

                if (count == 2)
                {
                    if (txtOutput.Text.Contains("Route between : " + _connectNodes[0] + " and " + _connectNodes[1]))
                    {
                        
                        MessageBox.Show("Both Points Already Connected...");
                        txtOutput.Text = "Route Already Exists : " + _connectNodes[0] + " and " + _connectNodes[1] + Environment.NewLine + txtOutput.Text;
                        _connectNodes.Clear();
                        count = 0;
                    }
                    else if (txtOutput.Text.Contains("Route between : " + _connectNodes[1] + " and " + _connectNodes[0]))
                    {
                        
                        MessageBox.Show("Both Points Already Connected...");
                        txtOutput.Text = "Route Already Exists : " + _connectNodes[1] + " and " + _connectNodes[0] + Environment.NewLine + txtOutput.Text;
                        _connectNodes.Clear();
                        count = 0;
                    }
                    else
                    {
                        map.GetRoute(GoogleMap, _connectNodes, zoomLevel);
                        map.loadMap(GoogleMap, zoomLevel);
                        txtOutput.Text = "Route between : " + _connectNodes[0] + " and " + _connectNodes[1] + Environment.NewLine + txtOutput.Text;
                        _connectNodes.Clear();
                        count = 0;
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
