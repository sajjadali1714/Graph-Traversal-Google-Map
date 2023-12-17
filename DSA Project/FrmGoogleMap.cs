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
            map.loadMap(Map, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text));
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            try
            {
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {
            try
            {
                map.getRoute(Map, _points[0], _points[1], 14);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
