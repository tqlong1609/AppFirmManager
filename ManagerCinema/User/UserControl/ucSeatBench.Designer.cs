namespace ManagerCinema
{
    partial class ucSeatBench
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
            this.lbRow = new System.Windows.Forms.Label();
            this.pnlSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lbRow
            // 
            this.lbRow.AutoSize = true;
            this.lbRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbRow.Location = new System.Drawing.Point(7, 7);
            this.lbRow.Name = "lbRow";
            this.lbRow.Size = new System.Drawing.Size(14, 20);
            this.lbRow.TabIndex = 67;
            this.lbRow.Text = "I";
            // 
            // pnlSeat
            // 
            this.pnlSeat.Location = new System.Drawing.Point(33, 3);
            this.pnlSeat.Name = "pnlSeat";
            this.pnlSeat.Size = new System.Drawing.Size(464, 33);
            this.pnlSeat.TabIndex = 69;
            // 
            // ucSeatBench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.pnlSeat);
            this.Controls.Add(this.lbRow);
            this.Name = "ucSeatBench";
            this.Size = new System.Drawing.Size(499, 40);
            this.Load += new System.EventHandler(this.ucSeatBench_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRow;
        private System.Windows.Forms.FlowLayoutPanel pnlSeat;
    }
}
