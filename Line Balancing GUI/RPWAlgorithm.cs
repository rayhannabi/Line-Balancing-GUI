using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphLibrary;

namespace Line_Balancing_GUI
{
    class RPWAlgorithm
    {
        private float taktTime;
        private int numberOfData;

        private int[,] workstations;
        private int[,] precedence;

        private List<string[]> precedenceSequence;
        private List<KeyValuePair<int, float>> normalTimeSequence;
        private string[] normalPrecedenceData;
        private string[] rpwPrecedenceData;

        private List<KeyValuePair<int, float>> RPWTimeSequence;

        public RPWAlgorithm(float taktTime, int numberOfData,
            string[] precedenceData,
            List<string[]> precedenceSequence,
            List<KeyValuePair<int, float>> normalTimeSequence)
        {
            this.normalTimeSequence = normalTimeSequence;
            this.numberOfData = numberOfData;
            this.precedenceSequence = precedenceSequence;
            this.normalPrecedenceData = precedenceData;
            this.taktTime = taktTime;

            rpwPrecedenceData = new string[normalPrecedenceData.Length];
            RPWTimeSequence = new List<KeyValuePair<int, float>>();
        }

        public int[,] AnalyzeWorkload(out float efficiency, out float totalTime, out int numberOfWorkstations)
        {
            // Call Graph
            // parse precedence, process data, create RPW Time sequence
            // Apply LCR

            RPWTimeSequence = analyzePrecedenceGraph();

            if (RPWTimeSequence != null)
            {
                LCRAlgorithm lcr = new LCRAlgorithm(taktTime, numberOfData, normalPrecedenceData, RPWTimeSequence);
                precedence = lcr.AnalyzePrecedence();
                workstations = lcr.AnalyzeWorkLoad(out efficiency, out totalTime, out numberOfWorkstations);

                return workstations;
            }

            efficiency = totalTime = numberOfWorkstations = 0;
            return null;
        }

        private List<KeyValuePair<int, float>> analyzePrecedenceGraph()
        {
            // Data parsing from graph
            DataParser dp = new DataParser(precedenceSequence, normalTimeSequence);
            DGraph dGraph = dp.ParseData();
            DGraph rpwGraph = dp.PerformRPWDist(dGraph);

            // Sort List based on vertex sum time
            List<Vertex> v = rpwGraph.Vertices;
            List<Vertex> sortedList = v.OrderByDescending(vtx => vtx.StandardTime).ToList();

            List<KeyValuePair<int, float>> rpwTimeSeq = new List<KeyValuePair<int, float>>();
            for (int i = 0; i < sortedList.Count; i++)
            {
                int index =
                    sortedList[i].ID;
                float st = normalTimeSequence
                    .Find(kvp => kvp.Key == index).Value;

                KeyValuePair<int, float> rpwKvp = new KeyValuePair<int, float>(index, st);
                rpwTimeSeq.Add(rpwKvp);
            }

            Dictionary<int, string> piNormal =
                new Dictionary<int, string>();
            // updating precedence data
            for (int i = 0; i < normalPrecedenceData.Length; i++)
            {
                piNormal.Add(normalTimeSequence[i].Key,
                    normalPrecedenceData[i]);
            }

            for (int i = 0; i < piNormal.Count; i++)
            {
                int key = rpwTimeSeq[i].Key;
                string value = piNormal[key];
                rpwPrecedenceData[i] = value;
            }

            return rpwTimeSeq;
        }

        public int[,] AnalyzePrecedence()
        {
            return precedence;
        }
    }
}
