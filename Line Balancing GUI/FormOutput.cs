using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Line_Balancing_GUI
{
    public partial class FormOutput : Form
    {
        private int[,] precedence;
        private int[,] workstations;
        private int numberOfWorkstation;
        private float totalTime;
        private float efficiency;
        private string[] metadata;
        private string[] workElement;
        private string[] machineData;
        private List<KeyValuePair<int, float>> timesq;

        public FormOutput(Dictionary<string, object> bundle)
        {
            InitializeComponent();
            // bundle recieved
            // unpack bundle if not empty
            if (bundle != null)
            {
                precedence = (int[,])bundle["p"];
                workstations = (int[,])bundle["w"];
                numberOfWorkstation = (int)bundle["n"];
                totalTime = (float)bundle["t"];
                efficiency = (float)bundle["e"];
                metadata = (string[])bundle["m"];
                workElement = (string[])bundle["we"];
                machineData = (string[])bundle["mn"];
                timesq = (List<KeyValuePair<int, float>>)bundle["ts"];

                Text = Application.ProductName + " - " + 
                    bundle["at"].ToString() + " Output";

                tbSample.Text = metadata[0];
                tbStyle.Text = metadata[1];
                tbType.Text = metadata[2];
                lblTaktTime.Text = metadata[3];

                lblTotalTime.Text = totalTime.ToString();
                lblEfficiency.Text = (Math.Round(
                    double.Parse(efficiency.ToString()),
                    2)).ToString() + "%";
                lblNumWSTN.Text = numberOfWorkstation.ToString();

                List<int> index = new List<int>();
                List<string> element_name = new List<string>();
                List<float> st = new List<float>();
                List<string> mdata = new List<string>();


                for (int i = 0; i < numberOfWorkstation; i++)
                {
                    #region Workstaion view

                    for (int j = 0; workstations[i, j] != -1; j++)
                    {
                        int data = workstations[i, j];

                        element_name.Add(workElement[data - 1]);
                        mdata.Add(machineData[data - 1]);
                        st.Add(timesq.ElementAt(data - 1).Value);
                        index.Add(timesq.ElementAt(data - 1).Key);
                    }

                    float sum = 0;
                    foreach (var item in st)
                    {
                        sum += item;
                    }

                    WorkStationView wsview = new WorkStationView(index, element_name, mdata, st, i, sum);
                    wsview.Visible = true;
                    wsview.Margin = new Padding(panelContainer.Width / 2 - wsview.Width / 2, 5, 10, 5);
                    wsview.Show();

                    panelContainer.Controls.Add(wsview);

                    // Reset data container
                    index = new List<int>();
                    element_name = new List<string>();
                    mdata = new List<string>();
                    st = new List<float>();
                    wsview = null;

                    #endregion
                }
            }
        }
    }
}
