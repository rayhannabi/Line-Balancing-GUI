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
    public partial class FormDataEntry : Form
    {
        private string element;
        private string prec_data;
        private string machine_name;
        private float s_time;

        private int index;

        private List<KeyValuePair<int, float>> _timeSequence;
        private List<string> _precedenceData;
        private List<string> _works;
        private List<string> _machineData;

        public List<KeyValuePair<int, float>> TimeSequence { get => _timeSequence; }
        public List<string> PrecedenceData { get => _precedenceData; }
        public List<string> Works { get => _works; }
        public List<string> MachineData { get => _machineData; }

        public FormDataEntry()
        {
            InitializeComponent();
            _timeSequence = new List<KeyValuePair<int, float>>();
            _precedenceData = new List<string>();
            _machineData = new List<string>();
            _works = new List<string>();
            index = 0;

            tbName.Focus();
            this.Text = Application.ProductName;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Length > 0
                && tbPrecedence.Text.Length > 0
                && tbMachineName.Text.Length > 0
                && tbTime.Text.Length > 0)
            {
                element = tbName.Text;
                prec_data = tbPrecedence.Text;
                machine_name = tbMachineName.Text;
                s_time = 0;
                if (float.TryParse(tbTime.Text, out s_time))
                {
                    // Add Entry
                    _precedenceData.Add(prec_data);
                    _works.Add(element);
                    _machineData.Add(machine_name);

                    // Time sequence entry
                    KeyValuePair<int, float> t_sq_data =
                        new KeyValuePair<int, float>(index + 1, s_time);
                    _timeSequence.Add(t_sq_data);
                    index++;
                    lblStatus.Text = string.Format("{0} item/s added", index);

                    // Clearing text
                    tbName.Clear();
                    tbPrecedence.Clear();
                    tbMachineName.Clear();
                    tbTime.Clear();
                    tbName.Focus();
                }
                else
                    lblStatus.Text = "Time must be decimal";
            }
            else
                lblStatus.Text = "Empty Field!";
        }

        private void btnAddData_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.White;
        }

        private void btnAddData_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = Color.Black;
        }
    }
}
