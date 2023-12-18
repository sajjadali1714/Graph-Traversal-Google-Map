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
        }

        private void btnLoadMap_Click(object sender, EventArgs e)
        {
            map.loadMap(GoogleMap, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text), true);
        }

        private void btnAdd(object sender, EventArgs e)
        {
            try
            {
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));
                txtOutput.Text = "Point Addedd : latitude " + txtLat.Text + " longitude " + txtLng.Text + Environment.NewLine +txtOutput.Text;
                txtLng.Text = String.Empty;
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
                    map.GetRoute(GoogleMap, _points[0], _points[1], 13);
                    map.loadMap(GoogleMap, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text), false);
                    txtOutput.Text = "Route between : " + _points[0] + " and " + _points[1] + Environment.NewLine + txtOutput.Text;
                    _points.Clear();

                } else if(btnGet.Text == "Get Polygon")
                {
                    map.GetPolygon(GoogleMap, _points, "My Area");
                    map.loadMap(GoogleMap, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text), false);
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
