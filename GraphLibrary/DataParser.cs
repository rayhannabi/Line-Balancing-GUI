using System;
using System.Collections.Generic;

namespace GraphLibrary
{
    public class DataParser
    {
        private List<string[]> precedenceSequence;
        private List<KeyValuePair<int, float>> timeSequence;

        private Vertex[] vertices;
        private Edge[] edges;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="precedenceSequence">List<string[]> of sequence data</param>
        public DataParser(List<string[]> precedenceSequence,
            List<KeyValuePair<int, float>> timeSequence)
        {
            this.precedenceSequence = precedenceSequence;
            this.timeSequence = timeSequence;

            vertices = new Vertex[timeSequence.Count];
            edges = new Edge[precedenceSequence.Count];
        }

        /// <summary>
        /// Parses data as Directed Acyclic Graph
        /// </summary>
        /// <returns>DGraph object, a Directed Acyclic Graph</returns>
        public DGraph ParseData()
        {
            // create all vertex of graph
            for (int i = 0; i < vertices.Length; i++)
            {
                Vertex v = new Vertex();
                v.ID = timeSequence[i].Key;
                v.StandardTime = timeSequence[i].Value;
                vertices[i] = v;
            }

            // create edges with connection
            for (int i = 0; i < precedenceSequence.Count; i++)
            {
                string[] dt = precedenceSequence[i];
                int from = int.Parse(dt[1]);
                int to = int.Parse(dt[0]);

                Edge e = new Edge();
                var vertexAquired = Array.Find(vertices, s => s.ID == to);
                var vertexTo = vertexAquired;

                vertexAquired = Array.Find(vertices, s => s.ID == from);

                var vertexFrom = vertexAquired;
                e.FromVertex = vertexFrom;
                e.ToVertex = vertexTo;
                if (e.FromVertex != null)
                {
                    e.FromVertex.Edges.Add(e);
                }
                edges[i] = e;
            }

            DGraph d = new DGraph();
            foreach (var item in vertices)
            {
                d.Vertices.Add(item);
            }

            foreach (var item in edges)
            {
                d.Edges.Add(item);
            }

            return d;
        }

        /// <summary>
        /// Performs Rank Positional Weight(RPW) operation on Precedence Graph
        /// </summary>
        /// <param name="graph">A Directed Acyclic Graph of Precedence data</param>
        /// <returns>RPW graph</returns>
        public DGraph PerformRPWDist(DGraph graph)
        {
            for (int i = graph.Edges.Count - 1; i >= 0; i--)
            {
                if (graph.Edges[i].FromVertex != null)
                {
                    graph.Edges[i].FromVertex.StandardTime +=
                        graph.Edges[i].ToVertex.StandardTime;
                }
            }

            return graph;
        }
    }
}
