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
    public partial class FrmMain : Form
    {
        private int childFormNumber = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void googleMapVisualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGoogleMap GM = new FrmGoogleMap();
            GM.MdiParent = this;
            GM.WindowState = FormWindowState.Maximized;
            GM.Dock = DockStyle.Fill;
            GM.Show();
        }

        private void graphVisualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGraph GP = new FrmGraph();
            GP.MdiParent = this;
            GP.WindowState = FormWindowState.Maximized;
            GP.Dock = DockStyle.Fill;
            GP.Show();
           

        }

        private void treeVisualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTree FT = new FrmTree();
            FT.MdiParent = this;
            FT.WindowState = FormWindowState.Maximized;
            FT.Dock = DockStyle.Fill;
            FT.Show();
        }
    }
}
