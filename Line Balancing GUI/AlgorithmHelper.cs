using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Line_Balancing_GUI
{
    public class AlgorithmHelper
    {
        public int[,] Workstations { get; set; }
        public int NumberOfWorkstations { get; set; }
        public float Efficiency
        {
            get;set;
        }
        public float TotalTime { get; set; }
        public string[] WorkElements { get; set; }
        public string[] MachineNames { get; set; }
        
        public List<KeyValuePair<int, float>> TimeSequence { get; set; } 
        public AlgorithmType Type { get; set; }
    }
}
