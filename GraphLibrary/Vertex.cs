using System.Collections.Generic;

namespace GraphLibrary
{
    public class Vertex
    {
        public int ID { get; set; }
        public float StandardTime { get; set; }

        public List<Edge> Edges { get; set; }

        public Vertex()
        {
            Edges = new List<Edge>();
        }
    }
}
