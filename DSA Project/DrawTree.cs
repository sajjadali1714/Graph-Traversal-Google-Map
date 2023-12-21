using System.Collections.Generic;
using System.Drawing;
namespace DSA_Project
{
    public class TreeNode
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode()
        {
            Children = new List<TreeNode>();
        }

        public void DrawNode(Graphics g, int nodeRadius)
        {
            // Draw the node
            g.FillEllipse(Brushes.Aqua, X - nodeRadius, Y - nodeRadius, 2 * nodeRadius, 2 * nodeRadius);
            g.DrawEllipse(Pens.Black, X - nodeRadius, Y - nodeRadius, 2 * nodeRadius, 2 * nodeRadius);
            g.DrawString(Name, new Font("Arial", 10), Brushes.Black, X - nodeRadius / 2, Y - nodeRadius / 2);

            // Draw lines to its children
            foreach (var child in Children)
            {
                g.DrawLine(Pens.Black, X, Y + nodeRadius, child.X, child.Y - nodeRadius);
                child.DrawNode(g, nodeRadius); // Recursively draw children
            }
        }
    }
}
