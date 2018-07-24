using System.Collections.Generic;

namespace GraphLibrary
{

    public class DGraph
    {
        public List<Vertex> Vertices { get; set; }
        public List<Edge> Edges { get; set; }

        public DGraph()
        {
            Vertices = new List<Vertex>();
            Edges = new List<Edge>();
        }
    }
}
