using GMap.NET;
using Newtonsoft.Json.Linq;
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
                int value = edge.Value;

                Node newNode = new Node
                {
                    Dest = dest,
                    Next = newGraph.Head[src],
                    Value = value
                };

                newGraph.Head[src] = newNode;
            }

            return newGraph;
        }

        public void AddEdge(Edge edge)
        {
            int src = edge.Src;
            int dest = edge.Dest;
            int value = edge.Value;
            Node newNode = new Node
            {
                Dest = dest,
                Next = graph.Head[src],
                Value = value
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
        public int Value { get; set; }
    }

    // Create Graph Edges / Connection
    public class Edge
    {

        public int Src { get; set; }
        public int Dest { get; set; }
        public int Value { get; set; }
        
    }


}
