using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public partial class FrmGraph : Form
    {
        private List<GraphNode> nodes = new List<GraphNode>();
        private GraphNode selectedNode;
        private Point lineStart;
        public FrmGraph()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // Event handlers for drawing and mouse interactions
            pictureBox1.Paint += PictureBox1_Paint;
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Draw nodes and lines
            DrawGraph(e.Graphics);
        }

        private void DrawGraph(Graphics g)
        {
            // Draw lines
            foreach (GraphNode node in nodes)
            {
                foreach (GraphNode connectedNode in node.ConnectedNodes)
                {
                    g.DrawLine(Pens.Black, node.Location, connectedNode.Location);
                }
            }

            // Draw nodes
            foreach (GraphNode node in nodes)
            {
                g.FillEllipse(Brushes.Aqua, node.Location.X - 20, node.Location.Y - 20, 40, 40);
                g.DrawEllipse(Pens.Black, node.Location.X - 20, node.Location.Y - 20, 40, 40);
                g.DrawString(node.Name, Font, Brushes.Black, node.Location.X - 10, node.Location.Y - 10);
            }
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // If a node is selected, update the line's end point while moving the mouse
            if (selectedNode != null)
            {
                pictureBox1.Invalidate(); // Invalidate to force repaint
            }
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedNode == null)
            {
                // Check if the user clicked on a node
                selectedNode = GetNodeAtLocation(e.Location);

                if (selectedNode == null)
                {
                    // If no node is clicked, add a new node at the clicked location
                    AddNodeAtLocation(e.Location);

                    // Redraw the entire graph
                    pictureBox1.Invalidate();
                }
            }
        }

        

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // If a node is selected and the mouse is released over another node, create a link
            if (selectedNode != null)
            {
                GraphNode targetNode = GetNodeAtLocation(e.Location);

                if (targetNode != null && targetNode != selectedNode)
                {
                    // Connect nodes
                    selectedNode.ConnectedNodes.Add(targetNode);
                    targetNode.ConnectedNodes.Add(selectedNode);

                    // Redraw the entire graph
                    pictureBox1.Invalidate();
                }
            }

            selectedNode = null;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            // If a link creation is not in progress, add a new node at the clicked location
            if (selectedNode == null)
            {
                MouseEventArgs mouseEventArgs = e as MouseEventArgs;
                AddNodeAtLocation(mouseEventArgs.Location);
            }
        }

        private GraphNode GetNodeAtLocation(Point location)
        {
            return nodes.Find(node =>
                location.X >= node.Location.X - 20 && location.X <= node.Location.X + 20 &&
                location.Y >= node.Location.Y - 20 && location.Y <= node.Location.Y + 20
            );
        }

        private void AddNodeAtLocation(Point location)
        {
            // Add a new node to the graph at the clicked location
            string newNodeName = $"{nodes.Count + 1}";
            nodes.Add(new GraphNode(location, newNodeName,0.0,0.0));            
            // Redraw the entire graph
            pictureBox1.Invalidate();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            GraphNode node = new GraphNode();
            DepthFirstSearch(node);          
        }

        private void DepthFirstSearch(GraphNode startNode)
        {
            HashSet<GraphNode> visited = new HashSet<GraphNode>();

            foreach (GraphNode startNodeA in nodes)
            {
                if (!visited.Contains(startNodeA))
                {
                    TraverseDFS(startNodeA, visited);
                }
            }
        }
        private void TraverseDFS(GraphNode currentNode, HashSet<GraphNode> visited)
        {
            if (currentNode == null || visited.Contains(currentNode))
            {
                return;
            }

            visited.Add(currentNode);
            textBox1.Text = textBox1.Text + $"Visited node: {currentNode.Name}" + Environment.NewLine;

            foreach (GraphNode connectedNode in currentNode.ConnectedNodes)
            {
                TraverseDFS(connectedNode, visited);
            }
        }



    }    
}