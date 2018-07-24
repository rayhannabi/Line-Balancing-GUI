namespace Line_Balancing_GUI
{
    partial class WorkStationView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblWS = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblMachine);
            this.panel1.Controls.Add(this.lv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 284);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.lblWS);
            this.panel2.Controls.Add(this.lblSum);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 41);
            this.panel2.TabIndex = 4;
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.BackColor = System.Drawing.Color.Transparent;
            this.lblWS.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblWS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWS.ForeColor = System.Drawing.Color.MintCream;
            this.lblWS.Location = new System.Drawing.Point(0, 0);
            this.lblWS.Name = "lblWS";
            this.lblWS.Padding = new System.Windows.Forms.Padding(10);
            this.lblWS.Size = new System.Drawing.Size(104, 37);
            this.lblWS.TabIndex = 0;
            this.lblWS.Text = "Workstation";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.BackColor = System.Drawing.Color.Transparent;
            this.lblSum.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSum.ForeColor = System.Drawing.Color.White;
            this.lblSum.Location = new System.Drawing.Point(257, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Padding = new System.Windows.Forms.Padding(10);
            this.lblSum.Size = new System.Drawing.Size(96, 37);
            this.lblSum.TabIndex = 2;
            this.lblSum.Text = "Time Spent:";
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMachine.Location = new System.Drawing.Point(0, 41);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Padding = new System.Windows.Forms.Padding(10);
            this.lblMachine.Size = new System.Drawing.Size(63, 37);
            this.lblMachine.TabIndex = 3;
            this.lblMachine.Text = "label1";
            // 
            // lv
            // 
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(0, 78);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(353, 204);
            this.lv.TabIndex = 1;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Work Element";
            this.columnHeader2.Width = 159;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Standard Time";
            this.columnHeader3.Width = 102;
            // 
            // WorkStationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(333, 250);
            this.Name = "WorkStationView";
            this.Size = new System.Drawing.Size(355, 284);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblWS;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Panel panel2;
    }
}
