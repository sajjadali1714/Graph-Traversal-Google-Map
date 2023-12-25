using GMap.NET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DSA_Project.Classes
{
    
    public class GraphHandler
    {
        private Graph graph;

        public GraphHandler(int n)
        {
            InitializeGraph(n);
        }

        private void InitializeGraph(int n)
        {
            graph = new Graph(n);
        }

        public Graph CreateGraph(List<Edge> edges)
        {
            Graph newGraph = new Graph(graph.Head.Length);

            foreach (var edge in edges)
            {
                int src = edge.Src;
                int dest = edge.Dest;
                int lat = edge.src_point;
                int lng = edge.dest_point;

                Node newNode = new Node
                {
                    Dest = dest,
                    Next = newGraph.Head[src],
                    src_point = edge.src_point,
                    dest_point = edge.dest_point
                };

                newGraph.Head[src] = newNode;
            }

            return newGraph;
        }

        public void AddEdge(Edge edge)
        {
            int src = edge.Src;
            int dest = edge.Dest;
            int src_point = edge.src_point;
            int dest_point = edge.dest_point;

            Node newNode = new Node
            {
                Dest = dest,
                Next = graph.Head[src],
                src_point = edge.src_point,
                dest_point = edge.dest_point
        };

            graph.Head[src] = newNode;
        }

        public String PrintGraph()
        {
            string v_return = string.Empty;
            for (int i = 0; i < graph.Head.Length; i++)
            {
                Node ptr = graph.Head[i];
                while (ptr != null)
                {
                    v_return = v_return + $"({i} -> {ptr.Dest})\t ";
                    ptr = ptr.Next;
                }
                v_return = v_return + Environment.NewLine;
            }
            return v_return;
        }
    }

    // Create Graph
    public class Graph
    {
        public Node[] Head { get; set; }

        public Graph(int n)
        {
            Head = new Node[n];
            for (int i = 0; i < n; i++)
            {
                Head[i] = null;
            }
        }
    }

    // Create Graph Node
    public class Node
    {
        public int Dest { get; set; }
        public Node Next { get; set; }
        public int src_point { get; set; }
        public int dest_point { get; set; }
    }

    // Create Graph Edges / Connection
    public class Edge
    {

        public int Src { get; set; }
        public int Dest { get; set; }
        public int src_point { get; set; }
        public int dest_point { get; set; }
    }


}
