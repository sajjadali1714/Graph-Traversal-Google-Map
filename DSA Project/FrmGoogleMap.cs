using DSA_Project.Classes;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
        private List<Edge> edges = new List<Edge>();
        GoogleMap map = new GoogleMap();
        Traversal traversal = new Traversal();
        private int zoomLevel = 13;
        int count = 0;
        int totalMarkers = 0;
        String[] src, dest;
        private Graph _graph;



        public FrmGoogleMap()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            _connectNodes = new List<PointLatLng>();
            map.loadMap(GoogleMap, zoomLevel);
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (_points.Count >= 3)
                {
                    map.GetPolygon(GoogleMap, _points, "My Area");
                    map.loadMap(GoogleMap, zoomLevel);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void GoogleMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    var point = GoogleMap.FromLocalToLatLng(e.X, e.Y);
                    _points.Add(new PointLatLng(point.Lat, point.Lng));
                    map.addMarker(GoogleMap, _points, totalMarkers, GMarkerGoogleType.red_dot);
                    totalMarkers++;
                    map.loadMap(GoogleMap, zoomLevel);
                    txtOutput.Text = "Point Addedd : latitude " + point.Lat + " longitude " + point.Lng + Environment.NewLine + txtOutput.Text;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void btnAdjacencyList_Click(object sender, EventArgs e)
        {
            try
            {
                GraphHandler graph = new GraphHandler(totalMarkers);
                foreach (Edge edge in edges)
                {
                    graph.AddEdge(edge);
                }
                _graph = graph.CreateGraph(edges);
                txtOutput.Text = graph.PrintGraph() + Environment.NewLine;
                txtOutput.Text = "Depth First Search    : " + traversal.DepthFirstSearch(_graph, 0, null) + Environment.NewLine + txtOutput.Text;
                //txtOutput.Text = "Breadth First Search : " + traversal.BreadthFirstSearch(_graph, 0, pic_arrow) + Environment.NewLine + txtOutput.Text;

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
                GMapMarker marker = GoogleMap.Overlays.SelectMany(overlay => overlay.Markers).FirstOrDefault(m => m.IsMouseOver);
                if (GoogleMap.IsMouseOverMarker == true)
                {
                    if (marker != null)
                    {
                        // Access the Position property to get the latitude and longitude                        
                        txtOutput.Text = marker.Position.Lat + " - " + marker.Position.Lng + Environment.NewLine + txtOutput.Text;
                    }
                    var point = GoogleMap.FromLocalToLatLng(e.X, e.Y);
                    _connectNodes.Add(new PointLatLng(marker.Position.Lat, marker.Position.Lng));
                    count++;

                }
                if (count == 1)
                {
                    src = marker.ToolTipText.Split(',');


                }
                else if (count == 2)
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
                        dest = marker.ToolTipText.Split(',');

                        edges.Add(new Edge { Src = int.Parse(src[0].Substring(7)), Dest = int.Parse(dest[0].Substring(7)), Value = int.Parse(src[1].Substring(8)) });
                        edges.Add(new Edge { Src = int.Parse(dest[0].Substring(7)), Dest = int.Parse(src[0].Substring(7)), Value = int.Parse(dest[1].Substring(8)) });
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

