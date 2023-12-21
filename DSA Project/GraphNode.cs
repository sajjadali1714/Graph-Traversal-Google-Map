using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DSA_Project
{
    public class GraphNode
    {
        public Point Location { get; set; }
        public string Name { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }

        public List<GraphNode> ConnectedNodes { get; } = new List<GraphNode>();

        public GraphNode(Point location, string name, double lat, double lng)
        {
            Location = location;
            Name = name;
            lat = lat;
            lng = lng;
            
        }

        public GraphNode()
        {            
        }
    }
}

