using System;
using System.Collections.Generic;

namespace DSA_Project.Classes
{
    
    public class GraphHandler
    {
        private Graph graph;

        public GraphHandler()
        {
            InitializeGraph();
            PrintGraph();
        }

        private void InitializeGraph()
        {
            graph = new Graph(6);
        }

        public Graph CreateGraph(List<Edge> edges)
        {
            Graph newGraph = new Graph(graph.Head.Length);

            foreach (var edge in edges)
            {
                int src = edge.Src;
                int dest = edge.Dest;

                Node newNode = new Node
                {
                    Dest = dest,
                    Next = newGraph.Head[src]
                };

                newGraph.Head[src] = newNode;
            }

            return newGraph;
        }

        public void AddEdges()
        {
            List<Edge> userEdges = new List<Edge>();
        }

        private void PrintGraph()
        {
            for (int i = 0; i < graph.Head.Length; i++)
            {
                Node ptr = graph.Head[i];
                while (ptr != null)
                {
                    Console.Write($"({i} -> {ptr.Dest})\t ");
                    ptr = ptr.Next;
                }
                Console.WriteLine();
            }
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
    }

    // Create Graph Edges / Connection
    public class Edge
    {
        public int Src { get; set; }
        public int Dest { get; set; }
    }


}
