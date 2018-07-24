namespace Line_Balancing_GUI
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSample = new System.Windows.Forms.TextBox();
            this.tbStyleNo = new System.Windows.Forms.TextBox();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTAKTTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLCR = new System.Windows.Forms.Button();
            this.btnKWM = new System.Windows.Forms.Button();
            this.btnRPW = new System.Windows.Forms.Button();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnPD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sample Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Style No:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Types:";
            // 
            // tbSample
            // 
            this.tbSample.Location = new System.Drawing.Point(358, 112);
            this.tbSample.Name = "tbSample";
            this.tbSample.Size = new System.Drawing.Size(398, 25);
            this.tbSample.TabIndex = 3;
            // 
            // tbStyleNo
            // 
            this.tbStyleNo.Location = new System.Drawing.Point(358, 143);
            this.tbStyleNo.Name = "tbStyleNo";
            this.tbStyleNo.Size = new System.Drawing.Size(108, 25);
            this.tbStyleNo.TabIndex = 4;
            // 
            // comboTypes
            // 
            this.comboTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.Items.AddRange(new object[] {
            "T-Shirt",
            "Trouser",
            "Shirt",
            "Jeans Pant"});
            this.comboTypes.Location = new System.Drawing.Point(544, 143);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(212, 25);
            this.comboTypes.TabIndex = 5;
            this.comboTypes.Text = "<Select an item>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maximum Time Allowed Per Workstation:";
            // 
            // tbTAKTTime
            // 
            this.tbTAKTTime.Location = new System.Drawing.Point(358, 210);
            this.tbTAKTTime.Name = "tbTAKTTime";
            this.tbTAKTTime.Size = new System.Drawing.Size(100, 25);
            this.tbTAKTTime.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.lvData);
            this.groupBox1.Location = new System.Drawing.Point(27, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 342);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Element Specification";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Location = new System.Drawing.Point(780, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 36);
            this.panel1.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FlatAppearance.BorderSize = 2;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(88, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 36);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            this.btnReset.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnReset.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3,
            this.columnHeader4});
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(25, 36);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(918, 237);
            this.lvData.TabIndex = 0;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SL No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Work Element";
            this.columnHeader2.Width = 390;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Machine Name";
            this.columnHeader5.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precedence";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Standard Time";
            this.columnHeader4.Width = 124;
            // 
            // btnLCR
            // 
            this.btnLCR.BackColor = System.Drawing.Color.White;
            this.btnLCR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLCR.FlatAppearance.BorderSize = 2;
            this.btnLCR.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLCR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnLCR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLCR.ForeColor = System.Drawing.Color.Black;
            this.btnLCR.Location = new System.Drawing.Point(573, 623);
            this.btnLCR.Name = "btnLCR";
            this.btnLCR.Size = new System.Drawing.Size(75, 36);
            this.btnLCR.TabIndex = 9;
            this.btnLCR.Text = "LCR";
            this.btnLCR.UseVisualStyleBackColor = false;
            this.btnLCR.Click += new System.EventHandler(this.btnLCR_Click);
            this.btnLCR.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnLCR.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // btnKWM
            // 
            this.btnKWM.BackColor = System.Drawing.Color.White;
            this.btnKWM.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnKWM.FlatAppearance.BorderSize = 2;
            this.btnKWM.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnKWM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnKWM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKWM.ForeColor = System.Drawing.Color.Black;
            this.btnKWM.Location = new System.Drawing.Point(654, 623);
            this.btnKWM.Name = "btnKWM";
            this.btnKWM.Size = new System.Drawing.Size(75, 36);
            this.btnKWM.TabIndex = 10;
            this.btnKWM.Text = "KWM";
            this.btnKWM.UseVisualStyleBackColor = false;
            this.btnKWM.Click += new System.EventHandler(this.btnKWM_Click);
            this.btnKWM.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnKWM.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // btnRPW
            // 
            this.btnRPW.BackColor = System.Drawing.Color.White;
            this.btnRPW.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnRPW.FlatAppearance.BorderSize = 2;
            this.btnRPW.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnRPW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRPW.ForeColor = System.Drawing.Color.Black;
            this.btnRPW.Location = new System.Drawing.Point(735, 623);
            this.btnRPW.Name = "btnRPW";
            this.btnRPW.Size = new System.Drawing.Size(75, 36);
            this.btnRPW.TabIndex = 11;
            this.btnRPW.Text = "RPW";
            this.btnRPW.UseVisualStyleBackColor = false;
            this.btnRPW.Click += new System.EventHandler(this.btnRPW_Click);
            this.btnRPW.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnRPW.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(544, 214);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(87, 21);
            this.cbAuto.TabIndex = 16;
            this.cbAuto.Text = "Auto Input";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.White;
            this.btnAuto.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnAuto.FlatAppearance.BorderSize = 2;
            this.btnAuto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAuto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.Color.Black;
            this.btnAuto.Location = new System.Drawing.Point(637, 211);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(119, 26);
            this.btnAuto.TabIndex = 17;
            this.btnAuto.Text = "Read from File";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            this.btnAuto.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnAuto.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // btnPD
            // 
            this.btnPD.BackColor = System.Drawing.Color.White;
            this.btnPD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnPD.FlatAppearance.BorderSize = 2;
            this.btnPD.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnPD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPD.ForeColor = System.Drawing.Color.Black;
            this.btnPD.Location = new System.Drawing.Point(27, 623);
            this.btnPD.Name = "btnPD";
            this.btnPD.Size = new System.Drawing.Size(194, 36);
            this.btnPD.TabIndex = 18;
            this.btnPD.Text = "Precedence Diagram";
            this.btnPD.UseVisualStyleBackColor = false;
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            this.btnPD.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnPD.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1022, 85);
            this.label5.TabIndex = 19;
            this.label5.Text = "LINE BALANCING ANALYZER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.White;
            this.btnCompare.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCompare.FlatAppearance.BorderSize = 2;
            this.btnCompare.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCompare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.ForeColor = System.Drawing.Color.Black;
            this.btnCompare.Location = new System.Drawing.Point(840, 623);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(155, 36);
            this.btnCompare.TabIndex = 20;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            this.btnCompare.MouseEnter += new System.EventHandler(this.btnPD_MouseEnter);
            this.btnCompare.MouseLeave += new System.EventHandler(this.btnPD_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 683);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPD);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.cbAuto);
            this.Controls.Add(this.btnRPW);
            this.Controls.Add(this.btnKWM);
            this.Controls.Add(this.btnLCR);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbTAKTTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTypes);
            this.Controls.Add(this.tbStyleNo);
            this.Controls.Add(this.tbSample);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Balancing Analyzer";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSample;
        private System.Windows.Forms.TextBox tbStyleNo;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTAKTTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLCR;
        private System.Windows.Forms.Button btnKWM;
        private System.Windows.Forms.Button btnRPW;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnPD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnCompare;
    }
}

