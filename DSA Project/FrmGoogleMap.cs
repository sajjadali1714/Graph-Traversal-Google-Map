using DSA_Project.Classes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class FrmGoogleMap : Form
    {

        private List<PointLatLng> _points;
        GoogleMap map = new GoogleMap();
        public FrmGoogleMap()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            map.loadMap(GoogleMap);
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            map.loadMap(GoogleMap);
        }

        private void btnAdd(object sender, EventArgs e)
        {
            try
            {
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));
                map.addMarker(GoogleMap, _points);
                if(btnGet.Text == "Get Route")
                    map.GetRoute(GoogleMap, _points, 13);
                
                map.loadMap(GoogleMap);                
                txtOutput.Text = "Point Addedd : latitude " + txtLat.Text + " longitude " + txtLng.Text + Environment.NewLine +txtOutput.Text;
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
                if(btnGet.Text == "Get Route")
                {
                    if(_points.Count >= 2)
                    {
                        map.GetRoute(GoogleMap, _points, 13);
                        map.loadMap(GoogleMap);
                        txtOutput.Text = "Route between : " + _points[0] + " and " + _points[1] + Environment.NewLine + txtOutput.Text;                        
                    }
                    

                } else if(btnGet.Text == "Get Polygon")
                {
                    if (_points.Count >= 3)
                    {
                        map.GetPolygon(GoogleMap, _points, "My Area");
                        map.loadMap(GoogleMap);
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

                } else if (CmbOptions.Text == "Generate Polygon")
                {
                    btnGet.Text = "Get Polygon";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
