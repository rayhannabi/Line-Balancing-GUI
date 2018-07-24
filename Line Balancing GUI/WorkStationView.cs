using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Line_Balancing_GUI
{
    public partial class WorkStationView : UserControl
    {
        private int[] index;
        private string[] element_name;
        private float[] st;
        private List<string> machine_info;

        public WorkStationView()
        {
            InitializeComponent();

        }

        public WorkStationView(List<int> index, List<string> element_name, 
            List<string> mdata, List<float> st, int count, float sum)
        {
            InitializeComponent();

            lblWS.Text = "Workstation " + (count + 1);
            lblSum.Text = "Time spent: " + Math.Round(sum, 2);

            this.Index = index.ToArray();
            this.Element_name = element_name.ToArray();
            this.St = st.ToArray();
            this.Machine_info = mdata;

            var query = Machine_info.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => new { MachineName = y.Key, Counter = y.Count() })
              .ToList();

            StringBuilder sb = new StringBuilder();

            if (query.Count > 0)
            {
                foreach (var item in query)
                {
                    sb.AppendLine(string.Format("{0} x{1}", item.MachineName, item.Counter));
                }

            }
            else
            {
                foreach (var item in Machine_info)
                {
                    sb.AppendLine(string.Format("{0} x1", item));
                }
            }

            lblMachine.Text = sb.ToString();

            for (int i = 0; i < index.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = index[i].ToString();
                item.SubItems.Add(element_name[i]);
                item.SubItems.Add(st[i].ToString());

                lv.Items.Add(item);
            }
        }

        public int[] Index { get => index; set => index = value; }
        public string[] Element_name { get => element_name; set => element_name = value; }
        public float[] St { get => st; set => st = value; }
        public List<string> Machine_info { get => machine_info; set => machine_info = value; }
    }
}
