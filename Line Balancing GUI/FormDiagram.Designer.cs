namespace Line_Balancing_GUI
{
    partial class FormDiagram
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
            this.goViewDiagram = new Northwoods.Go.GoView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // goViewDiagram
            // 
            this.goViewDiagram.AllowCopy = false;
            this.goViewDiagram.AllowDelete = false;
            this.goViewDiagram.AllowDragOut = false;
            this.goViewDiagram.AllowDrop = false;
            this.goViewDiagram.AllowEdit = false;
            this.goViewDiagram.AllowInsert = false;
            this.goViewDiagram.AllowKey = false;
            this.goViewDiagram.AllowLink = false;
            this.goViewDiagram.AllowSelect = false;
            this.goViewDiagram.ArrowMoveLarge = 10F;
            this.goViewDiagram.ArrowMoveSmall = 1F;
            this.goViewDiagram.BackColor = System.Drawing.Color.White;
            this.goViewDiagram.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.goViewDiagram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goViewDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goViewDiagram.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
            this.goViewDiagram.Location = new System.Drawing.Point(0, 0);
            this.goViewDiagram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.goViewDiagram.Name = "goViewDiagram";
            this.goViewDiagram.Size = new System.Drawing.Size(969, 622);
            this.goViewDiagram.TabIndex = 0;
            this.goViewDiagram.Text = "goView1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(969, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRECEDENCE DIAGRAM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.goViewDiagram);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDiagram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Precedence Diagram";
            this.ResumeLayout(false);

        }

        #endregion

        private Northwoods.Go.GoView goViewDiagram;
        private System.Windows.Forms.Label label1;
    }
}