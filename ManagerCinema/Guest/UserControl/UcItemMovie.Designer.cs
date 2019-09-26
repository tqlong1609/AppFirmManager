namespace ManagerCinema
{
    partial class UcItemMovie
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
            this.pbxMovie = new System.Windows.Forms.PictureBox();
            this.lbNameMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMovie
            // 
            this.pbxMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMovie.Location = new System.Drawing.Point(6, 0);
            this.pbxMovie.Name = "pbxMovie";
            this.pbxMovie.Size = new System.Drawing.Size(391, 265);
            this.pbxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMovie.TabIndex = 0;
            this.pbxMovie.TabStop = false;
            this.pbxMovie.Click += new System.EventHandler(this.pbxMovie_Click);
            // 
            // lbNameMovie
            // 
            this.lbNameMovie.AutoSize = true;
            this.lbNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMovie.ForeColor = System.Drawing.Color.Gray;
            this.lbNameMovie.Location = new System.Drawing.Point(158, 271);
            this.lbNameMovie.Name = "lbNameMovie";
            this.lbNameMovie.Size = new System.Drawing.Size(51, 20);
            this.lbNameMovie.TabIndex = 1;
            this.lbNameMovie.Text = "label1";
            // 
            // UcItemMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.lbNameMovie);
            this.Controls.Add(this.pbxMovie);
            this.Name = "UcItemMovie";
            this.Size = new System.Drawing.Size(405, 308);
            this.Load += new System.EventHandler(this.UcItemMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMovie;
        private System.Windows.Forms.Label lbNameMovie;
    }
}
