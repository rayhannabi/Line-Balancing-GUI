using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Line_Balancing_GUI
{
    public partial class FormMain : Form
    {
        private List<KeyValuePair<int, float>> time_sequence;
        private string[] precedence_data;
        private string[] work_element;
        private string[] machine_data;

        // Processed data
        private float efficiency;
        private int[,] workstations;
        private int[,] precedence;
        private int numberOfWorkStation;
        private float totalTime;

        public FormMain()
        {
            InitializeComponent();
            btnAuto.Enabled = false;

            foreach (ColumnHeader item in lvData.Columns)
            {
                item.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // data recieve???
            FormDataEntry df = new FormDataEntry();
            df.ShowDialog(this);
            time_sequence = df.TimeSequence;
            precedence_data = df.PrecedenceData.ToArray();
            machine_data = df.MachineData.ToArray();
            work_element = df.Works.ToArray();

            if (time_sequence != null
                && precedence_data != null
                && machine_data != null)
            {
                for (int i = 0; i < time_sequence.Count; i++)
                {
                    var data = time_sequence.ElementAt(i);

                    ListViewItem item = new ListViewItem();
                    item.Text = data.Key.ToString();
                    item.SubItems.Add(work_element[i]);
                    item.SubItems.Add(machine_data[i]);
                    item.SubItems.Add(precedence_data[i]);
                    item.SubItems.Add(data.Value.ToString());
                    lvData.Items.Add(item);
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?\nAll Data will be deleted!",
                Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                lvData.Items.Clear();
                precedence_data = null;
                machine_data = null;
                work_element = null;
                time_sequence = null;
                tbSample.Clear();
                tbStyleNo.Clear();
                tbTAKTTime.Clear();
                comboTypes.ResetText();
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            lvData.Items.Clear();
            time_sequence = readInputFromFile(out precedence_data, out work_element, out machine_data);
            if (time_sequence != null)
            {              
                if (time_sequence != null && precedence_data != null)
                {
                    groupBox1.Enabled = true;

                    for (int i = 0; i < time_sequence.Count; i++)
                    {
                        var data = time_sequence.ElementAt(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = data.Key.ToString();
                        item.SubItems.Add(work_element[i]);
                        item.SubItems.Add(machine_data[i]);
                        item.SubItems.Add(precedence_data[i]);
                        item.SubItems.Add(data.Value.ToString());
                        lvData.Items.Add(item);
                    }
                }
            }
            else
                MessageBox.Show("File read failed!", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAuto.Checked)
            {
                btnAuto.Enabled = true;
                groupBox1.Enabled = false;
            }
            else
            {
                btnAuto.Enabled = false;
                groupBox1.Enabled = true;
            }
        }

        private void btnLCR_Click(object sender, EventArgs e)
        {
            if (tbSample.Text.Length > 0
                && tbStyleNo.Text.Length > 0
                && tbTAKTTime.Text.Length > 0
                && comboTypes.SelectedIndex >= 0)
            {
                try
                {
                    analyzeData(AlgorithmType.LCR);
                }
                catch (Exception)
                {
                    string errorText = "Maximum Time Allowed Per Workstation\n" + 
                        "exceeds Total Time to complete all tasks";
                    MessageBox.Show(errorText, "Application Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
                MessageBox.Show("One or more field is/are empty", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnKWM_Click(object sender, EventArgs e)
        {
            if (tbSample.Text.Length > 0
                && tbStyleNo.Text.Length > 0
                && tbTAKTTime.Text.Length > 0
                && comboTypes.SelectedIndex >= 0)
            {
                analyzeData(AlgorithmType.KWM);
            }
            else
                MessageBox.Show("One or more field is/are empty", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnRPW_Click(object sender, EventArgs e)
        {
            if (tbSample.Text.Length > 0
                && tbStyleNo.Text.Length > 0
                && tbTAKTTime.Text.Length > 0
                && comboTypes.SelectedIndex >= 0)
            {
                analyzeData(AlgorithmType.RPW);
            }
            else
                MessageBox.Show("One or more field is/are empty", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            List<string[]> pseq = parsePrecedenceData(time_sequence);

            if (pseq.Count > 0 && time_sequence != null)
            {
                new FormDiagram(pseq, time_sequence).ShowDialog(this);
            }
            else
                MessageBox.Show("Please add data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private List<string[]> parsePrecedenceData(List<KeyValuePair<int, float>> normalTimeSequence)
        {
            List<string[]> precedenceSequence = new List<string[]>();

            if (time_sequence != null)
            {
                int n = time_sequence.Count;

                for (int i = 0; i < n; i++)
                {

                    var item = time_sequence.ElementAt(i);

                    if (precedence_data[i].Contains("-"))
                    {
                        string[] d = new string[2];
                        d[0] = item.Key.ToString();
                        d[1] = "0";
                        precedenceSequence.Add(d);
                    }
                    else if (precedence_data[i].Contains(","))
                    {
                        string[] csv = precedence_data[i].Split(',');

                        for (int c = 0; c < csv.Length; c++)
                        {
                            string[] d = new string[2];
                            d[0] = item.Key.ToString();
                            d[1] = csv[c];
                            precedenceSequence.Add(d);
                        }
                    }
                    else
                    {
                        string[] d = new string[2];
                        d[0] = item.Key.ToString();
                        d[1] = precedence_data[i];
                        precedenceSequence.Add(d);
                    }
                }
            }

            return precedenceSequence;
        }

        private void analyzeData(AlgorithmType algoType)
        {
            float t_time = 0;
            if (float.TryParse(tbTAKTTime.Text, out t_time))
            {
                // pass to function
                // time_sequence
                // precedence

                if (time_sequence != null)
                {
                    if (t_time > 0)
                    {
                        switch (algoType)
                        {
                            case AlgorithmType.LCR:

                                // LCR implementation
                                LCRAlgorithm lcr = new LCRAlgorithm(t_time, time_sequence.Count,
                                    precedence_data, time_sequence);
                                precedence = lcr.AnalyzePrecedence();
                                workstations = lcr.AnalyzeWorkLoad(out efficiency,
                                    out totalTime, out numberOfWorkStation);

                                break;

                            case AlgorithmType.KWM:
                                KWMAlgorithm kwm = new KWMAlgorithm(t_time, time_sequence.Count,
                                    precedence_data, time_sequence);
                                precedence = kwm.AnalyzePrecedence();
                                workstations = kwm.AnalyzeWorkload(out efficiency,
                                    out totalTime, out numberOfWorkStation);

                                break;

                            case AlgorithmType.RPW:

                                List<string[]> precedenceSequence = parsePrecedenceData(time_sequence);

                                RPWAlgorithm rpw = new RPWAlgorithm(t_time, time_sequence.Count,
                                    precedence_data, precedenceSequence, time_sequence);
                                //precedence = rpw.AnalyzePrecedence();
                                workstations = rpw.AnalyzeWorkload(out efficiency,
                                    out totalTime, out numberOfWorkStation);

                                break;

                            default:
                                break;
                        }

                        // workstation output
                        // pack bundle for journey
                        string[] meta = { tbSample.Text, tbStyleNo.Text,
                            comboTypes.SelectedItem.ToString(),
                            tbTAKTTime.Text };

                        Dictionary<string, object> bundle = new Dictionary<string, object>();
                        bundle.Add("p", precedence);
                        bundle.Add("w", workstations);
                        bundle.Add("e", efficiency);
                        bundle.Add("t", totalTime);
                        bundle.Add("n", numberOfWorkStation);
                        bundle.Add("m", meta);
                        bundle.Add("we", work_element);
                        bundle.Add("mn", machine_data);
                        bundle.Add("ts", time_sequence);
                        bundle.Add("at", algoType.ToString());

                        new FormOutput(bundle).ShowDialog(this);
                    }
                    else
                        MessageBox.Show("Max time per workstation must be greater than zero",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please add data",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Max time per workstation must be a decimal value",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private List<KeyValuePair<int, float>> readInputFromFile(out string[] precedence_data,
           out string[] work_element, out string[] machine_data)
        {
            string path = "Resources\\LCR_DATA.txt";
            string[] fileread = File.ReadAllLines(path, Encoding.UTF8);
            List<String> p = new List<string>();
            List<String> w = new List<string>();
            List<String> m = new List<string>();

            for (int i = 0; i < 15; i++)
            {
                p.Add(fileread[i]);
            }

            for (int i = 15; i < 30; i++)
            {
                w.Add(fileread[i]);
            }

            for (int i = 30; i < 45; i++)
            {
                m.Add(fileread[i]);
            }

            List<KeyValuePair<int, float>> t = new List<KeyValuePair<int, float>>();

            for (int i = 45; i < 60; i++)
            {
                string dat = fileread[i];
                string[] d = dat.Split(' ');
                KeyValuePair<int, float> item = new KeyValuePair<int, float>(
                    int.Parse(d[0]), float.Parse(d[1]));
                t.Add(item);
            }

            precedence_data = p.ToArray();
            work_element = w.ToArray();
            machine_data = m.ToArray();
            return t;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (tbSample.Text.Length > 0
                && tbStyleNo.Text.Length > 0
                && tbTAKTTime.Text.Length > 0
                && comboTypes.SelectedIndex >= 0)
            {
                compareProcess();
            }
            else
                MessageBox.Show("One or more field is/are empty", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void compareProcess()
        {
            float t_time = 0;

            AlgorithmHelper lcrData = new AlgorithmHelper();
            AlgorithmHelper kwmData = new AlgorithmHelper();
            AlgorithmHelper rpwData = new AlgorithmHelper();

            if (float.TryParse(tbTAKTTime.Text, out t_time))
            {
                if (time_sequence != null)
                {
                    if (t_time > 0)
                    {
                        // LCR implementation
                        LCRAlgorithm lcr = new LCRAlgorithm(t_time, time_sequence.Count,
                            precedence_data, time_sequence);
                        precedence = lcr.AnalyzePrecedence();
                        lcrData.Workstations = lcr.AnalyzeWorkLoad(out efficiency,
                            out totalTime, out numberOfWorkStation);
                        lcrData.Efficiency = efficiency;
                        lcrData.TotalTime = totalTime;
                        lcrData.NumberOfWorkstations = numberOfWorkStation;
                        lcrData.Type = AlgorithmType.LCR;

                        // KWM Implementation
                        KWMAlgorithm kwm = new KWMAlgorithm(t_time, time_sequence.Count,
                                    precedence_data, time_sequence);
                        precedence = kwm.AnalyzePrecedence();
                        kwmData.Workstations = kwm.AnalyzeWorkload(out efficiency,
                            out totalTime, out numberOfWorkStation);
                        kwmData.Efficiency = efficiency;
                        kwmData.TotalTime = totalTime;
                        kwmData.NumberOfWorkstations = numberOfWorkStation;
                        kwmData.Type = AlgorithmType.KWM;

                        // RPW Implementation
                        List<string[]> precedenceSequence = parsePrecedenceData(time_sequence);

                        RPWAlgorithm rpw = new RPWAlgorithm(t_time, time_sequence.Count,
                            precedence_data, precedenceSequence, time_sequence);
                        //precedence = rpw.AnalyzePrecedence();
                        rpwData.Workstations = rpw.AnalyzeWorkload(out efficiency,
                            out totalTime, out numberOfWorkStation);
                        rpwData.Efficiency = efficiency;
                        rpwData.TotalTime = totalTime;
                        rpwData.NumberOfWorkstations = numberOfWorkStation;
                        rpwData.Type = AlgorithmType.RPW;

                        lcrData.WorkElements = kwmData.WorkElements =
                            rpwData.WorkElements = work_element;
                        lcrData.MachineNames = kwmData.MachineNames =
                            rpwData.MachineNames = machine_data;
                        lcrData.TimeSequence = kwmData.TimeSequence =
                            rpwData.TimeSequence = time_sequence;
                    }
                    else
                        MessageBox.Show("Max time per workstation must be greater than zero",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Please add data",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Max time per workstation must be a decimal value",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            Dictionary<object, object> bundle = new Dictionary<object, object>();
            bundle.Add(lcrData.Type, lcrData);
            bundle.Add(kwmData.Type, kwmData);
            bundle.Add(rpwData.Type, rpwData);

            new FormCompare(bundle).ShowDialog(this);
        }

        private void btnPD_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnPD_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }
    }
}
