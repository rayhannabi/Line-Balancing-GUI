using GraphLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TreeTester
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precedence Seq input
            List<string[]> d = new List<string[]>();

            for (int i = 0; i < 17; i++)
            {
                string s = Console.ReadLine();

                string[] ssv = s.Split(' ');
                d.Add(ssv);
            }

            foreach (var item in d)
            {
                Console.WriteLine(">>> {0} {1}", item[0], item[1]);
            }

            // Time Seq input
            List<KeyValuePair<int, float>> ts = new List<KeyValuePair<int, float>>();

            for (int i = 0; i < 15; i++)
            {
                ts.Add(new KeyValuePair<int, float>(i + 1,
                    float.Parse(Console.ReadLine())));
            }

            foreach (var item in ts)
            {
                Console.WriteLine(string
                    .Format("I: {0} ST: {1}",
                    item.Key, item.Value));
            }

            Console.WriteLine();

            DataParser dp = new DataParser(d, ts);
            DGraph dg = dp.ParseData();

            // Graph output
            foreach (var item in dg.Vertices)
            {
                int i = item.ID;
                float f = item.StandardTime;
                Console.WriteLine("I: {0} , ST : {1}", i, f);
            }

            Console.WriteLine();

            DGraph g = dg;
            DGraph output = dp.PerformRPWDist(g);

            // RPW graph output
            foreach (var item in output.Vertices)
            {
                int i = item.ID;
                float f = item.StandardTime;
                Console.WriteLine("I: {0} , Sum : {1}", i, f);
            }

            List<Vertex> v = output.Vertices;
            List<Vertex> sortedList = v.OrderByDescending(vtx => vtx.StandardTime).ToList();

            foreach (var item in sortedList)
            {
                Console.WriteLine("Index: {0},  Sum: {1}", item.ID, item.StandardTime);
            }

            // LcR data 
            List<KeyValuePair<int, float>> rpwTimeSeq = new List<KeyValuePair<int, float>>();
            for (int i = 0; i < sortedList.Count; i++)
            {
                int index =
                    sortedList[i].ID;
                float st = ts
                    .Find(kvp => kvp.Key == index).Value;

                KeyValuePair<int, float> rpwKvp = new KeyValuePair<int, float>(index, st);
                rpwTimeSeq.Add(rpwKvp);
            }

            foreach (var item in rpwTimeSeq)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }


            Console.ReadLine();
        }
    }
}
