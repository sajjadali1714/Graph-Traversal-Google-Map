using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project.Classes
{
    public class Traversal
    {
        GoogleMap map = new GoogleMap();
        private bool[] visited;
        string v_return = string.Empty;

        public string DepthFirstSearch(Graph graph, int startVertex, GMapControl GoogleMap)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = DFS(graph, startVertex, GoogleMap);
            return v_return;
        }

        public string BreadthFirstSearch(Graph graph, int startVertex, GMapControl GoogleMap)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = BFS(graph, startVertex, GoogleMap);
            return v_return;
        }

        private string DFS(Graph graph, int vertex,GMapControl GoogleMap)
        {
            visited[vertex] = true;
            v_return = v_return +  $" {vertex} ";

            Node node = graph.Head[vertex];
            while (node != null)
            {
                int adjVertex = node.Dest;
                if (!visited[adjVertex])
                {
                    map.addMarker(GoogleMap, null, -1, GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                    DFS(graph, adjVertex, GoogleMap);
                    

                }
                node = node.Next;
            }

            return v_return;
        }

        private string BFS(Graph graph, int startVertex, GMapControl GoogleMap)
        {
            Queue<int> queue = new Queue<int>();
            visited[startVertex] = true;
            queue.Enqueue(startVertex);

            while (queue.Count != 0)
            {
                startVertex = queue.Dequeue();
                v_return = v_return + $" {startVertex} ";

                Node node = graph.Head[startVertex];
                while (node != null)
                {
                    int adjVertex = node.Dest;
                    if (!visited[adjVertex])
                    {
                        visited[adjVertex] = true;
                        queue.Enqueue(adjVertex);
                        
                    }
                    node = node.Next;
                }
            }
            return v_return;
        }
    }
}



