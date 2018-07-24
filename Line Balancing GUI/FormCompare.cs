using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Line_Balancing_GUI
{
    public partial class FormCompare : Form
    {
        private Dictionary<object, object> bundle;
        private AlgorithmHelper lcr, kwm, rpw;

        public FormCompare()
        {
            InitializeComponent();
        }

        public FormCompare(Dictionary<object, object> bundle)
        {
            InitializeComponent();
            this.Text = Application.ProductName + " - Compare Results";
            this.bundle = bundle;
            lcr = (AlgorithmHelper)bundle[AlgorithmType.LCR];
            kwm = (AlgorithmHelper)bundle[AlgorithmType.KWM];
            rpw = (AlgorithmHelper)bundle[AlgorithmType.RPW];

            List<WorkStation> lcrWs = new List<WorkStation>();
            List<WorkStation> kwmWs = new List<WorkStation>();
            List<WorkStation> rpwWs = new List<WorkStation>();

            for (int i = 0; i < lcr.NumberOfWorkstations; i++)
            {
                List<int> index = new List<int>();
                List<float> st = new List<float>();
                List<string> mdata = new List<string>();
                for (int j = 0; lcr.Workstations[i, j] != -1; j++)
                {
                    int data = lcr.Workstations[i, j];

                    mdata.Add(lcr.MachineNames[data - 1]);
                    st.Add(lcr.TimeSequence.ElementAt(data - 1).Value);
                    index.Add(lcr.TimeSequence.ElementAt(data - 1).Key);
                }

                WorkStation ws = new WorkStation(index, mdata, i);
                lcrWs.Add(ws);
            }

            for (int i = 0; i < kwm.NumberOfWorkstations; i++)
            {
                List<int> index = new List<int>();
                List<float> st = new List<float>();
                List<string> mdata = new List<string>();
                for (int j = 0; kwm.Workstations[i, j] != -1; j++)
                {
                    int data = kwm.Workstations[i, j];

                    mdata.Add(kwm.MachineNames[data - 1]);
                    st.Add(kwm.TimeSequence.ElementAt(data - 1).Value);
                    index.Add(kwm.TimeSequence.ElementAt(data - 1).Key);
                }

                WorkStation ws = new WorkStation(index, mdata, i);
                kwmWs.Add(ws);
            }

            for (int i = 0; i < rpw.NumberOfWorkstations; i++)
            {
                List<int> index = new List<int>();
                List<float> st = new List<float>();
                List<string> mdata = new List<string>();
                for (int j = 0; rpw.Workstations[i, j] != -1; j++)
                {
                    int data = rpw.Workstations[i, j];

                    mdata.Add(rpw.MachineNames[data - 1]);
                    st.Add(rpw.TimeSequence.ElementAt(data - 1).Value);
                    index.Add(rpw.TimeSequence.ElementAt(data - 1).Key);
                }

                WorkStation ws = new WorkStation(index, mdata, i);
                rpwWs.Add(ws);
            }

            int[] count = { lcr.NumberOfWorkstations,
                kwm.NumberOfWorkstations, rpw.NumberOfWorkstations };

            int c = count.Max();
            lvOutput.Items.Clear();

            for (int i = 0; i < c; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "WS " + (i + 1);

                if (i < lcrWs.Count)
                    item.SubItems.Add(lcrWs.ElementAt(i).GetIndex() +
                        " | " + lcrWs.ElementAt(i).GetMachineNames());
                else
                    item.SubItems.Add("-");

                if (i < kwmWs.Count)
                    item.SubItems.Add(kwmWs.ElementAt(i).GetIndex() +
                        " | " + kwmWs.ElementAt(i).GetMachineNames());
                else
                    item.SubItems.Add("-");

                if (i < rpwWs.Count)
                    item.SubItems.Add(rpwWs.ElementAt(i).GetIndex() +
                    " | " + rpwWs.ElementAt(i).GetMachineNames());
                else
                    item.SubItems.Add("-");


                lvOutput.Items.Add(item);
            }

            lbKWME.Text = Math.Round(kwm.Efficiency, 2).ToString() + "%";
            lbLCRE.Text = Math.Round(lcr.Efficiency, 2).ToString() + "%";
            lbRPWE.Text = Math.Round(rpw.Efficiency, 2).ToString() + "%";
            lbKWMN.Text = kwm.NumberOfWorkstations.ToString();
            lbRPWN.Text = rpw.NumberOfWorkstations.ToString();
            lblLCRN.Text = lcr.NumberOfWorkstations.ToString();
        }

        public class WorkStation
        {
            private List<int> index;
            private List<string> mdata;
            private int i;

            public WorkStation(List<int> index, List<string> mdata, int i)
            {
                this.index = index;
                this.mdata = mdata;
                this.i = i;
            }

            public string GetMachineNames()
            {
                var query = mdata.GroupBy(x => x)
                    .Where(g => g.Count() > 1)
                    .Select(y => new { MachineName = y.Key, Counter = y.Count() });

                StringBuilder sb = new StringBuilder();

                if (query.Count() > 0)
                {
                    foreach (var item in query)
                    {
                        sb.Append(string.Format("{0} x{1};", item.MachineName, item.Counter));
                    }
                }
                else
                {
                    foreach (var item in mdata)
                    {
                        sb.Append(string.Format("{0} x1;", item));
                    }
                }

                return sb.ToString();
            }

            public string GetIndex()
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in index)
                {
                    sb.Append(string.Format(
                        "{0}, ", item));
                }

                return sb.ToString().Remove(sb.Length - 2);
            }

            public int GetCount()
            {
                return i + 1;
            }
        }
    }
}
