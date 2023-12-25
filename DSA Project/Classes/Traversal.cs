using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project.Classes
{
    public class Traversal
    {
        private bool[] visited;
        string v_return = string.Empty;

        public string DepthFirstSearch(Graph graph, int startVertex)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = DFS(graph, startVertex);
            return v_return;
        }

        public string BreadthFirstSearch(Graph graph, int startVertex)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = BFS(graph, startVertex);
            return v_return;
        }

        private string DFS(Graph graph, int vertex)
        {
            visited[vertex] = true;
            v_return = v_return +  $" {vertex} ";

            Node node = graph.Head[vertex];
            while (node != null)
            {
                int adjVertex = node.Dest;
                if (!visited[adjVertex])
                {
                    DFS(graph, adjVertex);
                }
                node = node.Next;
            }

            return v_return;
        }

        private string BFS(Graph graph, int startVertex)
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



