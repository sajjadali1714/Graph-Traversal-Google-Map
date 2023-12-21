using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace DSA_Project
{
    public partial class FrmTree : Form
    {
        private List<TreeNode> nodes = new List<TreeNode>();
        TreeNode tree = new TreeNode();

        public FrmTree()
        {
            InitializeComponent();

            // Create a TreeNode instance
            tree = new TreeNode { X = 100, Y = 50, Name = "10" };
            TreeNode node1 = new TreeNode { X = 50, Y = 150, Name = "4" };
            TreeNode node2 = new TreeNode { X = 200, Y = 150, Name = "7" };
            TreeNode node3 = new TreeNode { X = node1.X + 60, Y = node1.Y + 100, Name = "19" };

            tree.Children.Add(node1);
            tree.Children.Add(node2);
            node1.Children.Add(node3);

            // Attach the Paint event handler to the PictureBox
            picTreeDesign.Paint += picTreeDesign_Paint;
        }

        private void picTreeDesign_Paint(object sender, PaintEventArgs e)
        {
            if (tree != null)
            {
                
                tree.DrawNode(e.Graphics, 20);
            }
        }
    }
}

