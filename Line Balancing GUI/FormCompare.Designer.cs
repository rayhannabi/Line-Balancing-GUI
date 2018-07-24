namespace Line_Balancing_GUI
{
    partial class FormCompare
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ws 1",
            "1,2;Machine X1",
            "1,2;Machine X2",
            "1,2,3;Machine X2;MachineBasajdalkhfdalsdjlasdsd X2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ws 2",
            "3,4;M x1;M x2",
            "3,2;m1 x2;m2 x1",
            "3,4,5;mx x1;my x1;mz x2"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.lvOutput = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRPWN = new System.Windows.Forms.Label();
            this.lbRPWE = new System.Windows.Forms.Label();
            this.lbKWMN = new System.Windows.Forms.Label();
            this.lbKWME = new System.Windows.Forms.Label();
            this.lblLCRN = new System.Windows.Forms.Label();
            this.lbLCRE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1038, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result Comparison Between LCR, KWM and RPW Method";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvOutput
            // 
            this.lvOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvOutput.FullRowSelect = true;
            this.lvOutput.GridLines = true;
            listViewItem3.UseItemStyleForSubItems = false;
            this.lvOutput.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvOutput.Location = new System.Drawing.Point(0, 99);
            this.lvOutput.Name = "lvOutput";
            this.lvOutput.Size = new System.Drawing.Size(1038, 450);
            this.lvOutput.TabIndex = 1;
            this.lvOutput.UseCompatibleStateImageBehavior = false;
            this.lvOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Workstations";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "LCR";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "KWM";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "RPW";
            this.columnHeader4.Width = 300;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbRPWN);
            this.panel1.Controls.Add(this.lbRPWE);
            this.panel1.Controls.Add(this.lbKWMN);
            this.panel1.Controls.Add(this.lbKWME);
            this.panel1.Controls.Add(this.lblLCRN);
            this.panel1.Controls.Add(this.lbLCRE);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 106);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(822, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "RPW";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "KWM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "LCR";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRPWN
            // 
            this.lbRPWN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPWN.Location = new System.Drawing.Point(822, 69);
            this.lbRPWN.Name = "lbRPWN";
            this.lbRPWN.Size = new System.Drawing.Size(111, 29);
            this.lbRPWN.TabIndex = 10;
            this.lbRPWN.Text = "label12";
            this.lbRPWN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbRPWE
            // 
            this.lbRPWE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPWE.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbRPWE.Location = new System.Drawing.Point(822, 40);
            this.lbRPWE.Name = "lbRPWE";
            this.lbRPWE.Size = new System.Drawing.Size(111, 29);
            this.lbRPWE.TabIndex = 9;
            this.lbRPWE.Text = "label11";
            this.lbRPWE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKWMN
            // 
            this.lbKWMN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKWMN.Location = new System.Drawing.Point(509, 69);
            this.lbKWMN.Name = "lbKWMN";
            this.lbKWMN.Size = new System.Drawing.Size(111, 29);
            this.lbKWMN.TabIndex = 5;
            this.lbKWMN.Text = "label7";
            this.lbKWMN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbKWME
            // 
            this.lbKWME.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKWME.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbKWME.Location = new System.Drawing.Point(509, 40);
            this.lbKWME.Name = "lbKWME";
            this.lbKWME.Size = new System.Drawing.Size(111, 29);
            this.lbKWME.TabIndex = 4;
            this.lbKWME.Text = "label6";
            this.lbKWME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLCRN
            // 
            this.lblLCRN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLCRN.Location = new System.Drawing.Point(227, 69);
            this.lblLCRN.Name = "lblLCRN";
            this.lblLCRN.Size = new System.Drawing.Size(111, 29);
            this.lblLCRN.TabIndex = 3;
            this.lblLCRN.Text = "label5";
            this.lblLCRN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbLCRE
            // 
            this.lbLCRE.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLCRE.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbLCRE.Location = new System.Drawing.Point(227, 40);
            this.lbLCRE.Name = "lbLCRE";
            this.lbLCRE.Size = new System.Drawing.Size(111, 29);
            this.lbLCRE.TabIndex = 2;
            this.lbLCRE.Text = "label4";
            this.lbLCRE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Workstations:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Efficiency:";
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvOutput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Result Comparison";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOutput;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRPWN;
        private System.Windows.Forms.Label lbRPWE;
        private System.Windows.Forms.Label lbKWMN;
        private System.Windows.Forms.Label lbKWME;
        private System.Windows.Forms.Label lblLCRN;
        private System.Windows.Forms.Label lbLCRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}