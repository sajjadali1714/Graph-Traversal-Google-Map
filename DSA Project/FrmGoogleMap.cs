﻿using DSA_Project.Classes;
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

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            try
            {
                _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text)));
                txtOutput.Text = "Route Addedd : latitude " + txtLat.Text + " longitude " + txtLng.Text + Environment.NewLine +txtOutput.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGetRoute_Click(object sender, EventArgs e)
        {
            try
            {
                map.GetRoute(GoogleMap, _points[0], _points[1], 13);
                map.loadMap(GoogleMap, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text), false);
                txtOutput.Text = "Route between : " + _points[0] + " and " + _points[1] + Environment.NewLine + txtOutput.Text;
                _points.Clear();
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

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            

        }

        private void BtnAddPolygon_Click(object sender, EventArgs e)
        {
            try
            {
                map.GetPolygon(GoogleMap,_points, "My Area");
                map.loadMap(GoogleMap, Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLng.Text), false);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}