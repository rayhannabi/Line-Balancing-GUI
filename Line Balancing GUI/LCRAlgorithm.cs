using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Line_Balancing_GUI
{
    class LCRAlgorithm
    {
        private int numberOfData;
        private float takt_time;
        private float total_time;

        private int[,] precedence;
        private string[] precedenceData;

        private int[,] workstation;
        private List<KeyValuePair<int, float>> timeSequence;

        public LCRAlgorithm(float t_time, int n_data, string[] p_data, 
            List<KeyValuePair<int, float>> t_seq)
        {
            numberOfData = n_data;
            takt_time = t_time;
            precedenceData = p_data;
            timeSequence = t_seq;
            precedence = new int[numberOfData + 5, numberOfData + 5];

            // array init with -1
            for (int i = 1; i <= numberOfData; i++)
            {
                for (int j = 1; j <= numberOfData; j++)
                {
                    precedence[i, j] = -1;
                }
            }

            workstation = new int[numberOfData, numberOfData];
            for (int i = 0; i < numberOfData; i++)
            {
                for (int j = 0; j < numberOfData; j++)
                {
                    workstation[i, j] = -1;
                }
            }

            for (int i = 0; i < numberOfData; i++)
            {
                var item = timeSequence.ElementAt(i);
                total_time += item.Value;
            }
        }

        public int[,] AnalyzePrecedence()
        {
            for (int i = 0; i < numberOfData; i++)
            {
                string input = precedenceData[i];

                int index = 0, f = 1;
                int[] conv = new int[input.Length];
                int c_index = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '-')
                    {
                        precedence[i + 1, 0] = 0;
                        break;
                    }
                    if (input[j] != ',')
                    {
                        conv[c_index] = input[j] - '0';
                        c_index++;
                    }
                    else if (input[j] == ',')
                    {
                        int vv = 0;
                        f = 1;
                        for (c_index--; c_index > -1; c_index--)
                        {
                            vv += f * conv[c_index];
                            f *= 10;
                        }
                        c_index = 0;
                        precedence[i + 1, index] = vv;
                        index++;
                    }
                }

                if (c_index > 0)
                {
                    int vv = 0;
                    f = 1;

                    for (c_index--; c_index > -1; c_index--)
                    {
                        vv += f * conv[c_index];
                        f = f * 10;
                    }

                    c_index = 0;
                    precedence[i + 1, index] = vv;
                    index++;
                }
            }
            return precedence;
        }

        public int[,] AnalyzeWorkLoad(out float efficiency, out float totalTime, out int numberOfWorkStation)
        {
            int count = 0;
            bool[] check = new bool[numberOfData + 5];
            Array.Clear(check, 0, check.Length);
            check[0] = true;

            int num_ws = 0;
            float max_value = 0;

            int[,] workstation = new int[numberOfData, numberOfData];
            int ws_count = 0;

            for (int i = 0; i < numberOfData; i++)
            {
                for (int j = 0; j < numberOfData; j++)
                {
                    workstation[i, j] = -1;
                }
            }

            while (count < numberOfData)
            {
                float sum = 0;

                foreach (var item in timeSequence)
                {
                    int i = item.Key;
                    if (verify(i, precedence, check) == 1
                        && check[i] == false
                        && (sum + item.Value < (takt_time)))
                    {
                        sum = sum + item.Value;
                        check[i] = true;
                        workstation[num_ws, ws_count] = i;
                        count++;
                        ws_count++;
                    }
                }

                if (max_value < sum)
                {
                    max_value = sum;
                }
                num_ws++;
                ws_count = 0;
            }
            efficiency = total_time / (num_ws * max_value);
            efficiency = efficiency * 100;
            totalTime = total_time;
            numberOfWorkStation = num_ws;

            return workstation;
        }

        private int verify(int index, int[,] arr, bool[] cc)
        {
            int flag = 0;
            for (int i = 0; arr[index, i] != -1; i++)
            {
                if (cc[arr[index, i]] == true)
                    flag = 1;
                else
                {
                    flag = 0;
                    break;
                }
            }

            return flag;
        }
    }
}
