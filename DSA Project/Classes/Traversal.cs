using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA_Project.Classes
{
    public class Traversal
    {
        private bool[] visited;
        string v_return = string.Empty;

        public string DepthFirstSearch(Graph graph, int startVertex, PictureBox pic_arrow)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = DFS(graph, startVertex, pic_arrow);
            return v_return;
        }

        public string BreadthFirstSearch(Graph graph, int startVertex, PictureBox pic_arrow)
        {
            v_return = string.Empty;
            int vertices = graph.Head.Length;
            visited = new bool[vertices];
            v_return = BFS(graph, startVertex, pic_arrow);
            return v_return;
        }

        private string DFS(Graph graph, int vertex,PictureBox pic_arrow)
        {
            visited[vertex] = true;
            v_return = v_return +  $" {vertex} ";

            Node node = graph.Head[vertex];
            while (node != null)
            {
                int adjVertex = node.Dest;
                if (!visited[adjVertex])
                {
                    pic_arrow.Location = new Point(int.Parse(node.src_point.ToString()), int.Parse(node.dest_point.ToString()));
                    pic_arrow.Visible = true;
                    DFS(graph, adjVertex, pic_arrow);
                    

                }
                node = node.Next;
            }

            return v_return;
        }

        private string BFS(Graph graph, int startVertex, PictureBox pic_arrow)
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
                        pic_arrow.Location = new Point(int.Parse(node.src_point.ToString()), int.Parse(node.dest_point.ToString()));
                        pic_arrow.Visible = true;
                    }
                    node = node.Next;
                }
            }
            return v_return;
        }
    }
}



