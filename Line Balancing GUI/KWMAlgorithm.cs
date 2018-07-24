using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Line_Balancing_GUI
{
    class KWMAlgorithm
    {
        private float efficiency;
        private float totalTime;
        private int numberOfWorkstation;
        private int numberOfData;

        private int[,] ws;
        private int[,] prec;

        public KWMAlgorithm(float t_time, int n_data, string[] p_data,
            List<KeyValuePair<int, float>> t_seq)
        {
            numberOfData = n_data;
            LCRAlgorithm lcr = new LCRAlgorithm(t_time, n_data, p_data, t_seq);
            prec = lcr.AnalyzePrecedence();
            ws = lcr.AnalyzeWorkLoad(out efficiency, out totalTime, out numberOfWorkstation);
        }

        public int[,] AnalyzeWorkload(out float effc, out float total_time, out int num_ws)
        {
            effc = efficiency;
            total_time = totalTime;
            num_ws = numberOfWorkstation;

            int sp = numberOfWorkstation / 2;
            int[] temp = new int[numberOfData];
            sp--;

            int ss1 = 0;
            int ss2 = 0;

            for (int i = 0; ws[sp, i] != -1; i++)
            {
                temp[i] = ws[sp, i];
                ss1 = i;
            }
            ss1++;

            for (int i = 0; ws[sp + 1, i] != -1; i++)
            {
                ws[sp, i] = ws[sp + 1, i];
                ss2 = i;
            }
            ss2++;

            for (int i = 0; i < ss1; i++)
            {
                ws[sp + 1, i] = temp[i];
            }

            if (ss1 != ss2)
            {
                if (ss1 > ss2)
                {
                    for (int i = ss2; i < ss1; i++)
                    {
                        ws[sp, i] = -1;
                    }
                }
                else
                {
                    for (int i = ss1; i < ss2; i++)
                    {
                        ws[sp + 1, i] = -1;
                    }
                }
            }

            return ws;
        }

        public int[,] AnalyzePrecedence()
        {
            return prec;
        }
    }
}
