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
            this.btnBuyTicket = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMovie
            // 
            this.pbxMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMovie.Location = new System.Drawing.Point(3, 3);
            this.pbxMovie.Name = "pbxMovie";
            this.pbxMovie.Size = new System.Drawing.Size(415, 265);
            this.pbxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMovie.TabIndex = 0;
            this.pbxMovie.TabStop = false;
            this.pbxMovie.MouseLeave += new System.EventHandler(this.pbxMovie_MouseLeave);
            this.pbxMovie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxMovie_MouseMove);
            // 
            // lbNameMovie
            // 
            this.lbNameMovie.AutoSize = true;
            this.lbNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMovie.ForeColor = System.Drawing.Color.Gray;
            this.lbNameMovie.Location = new System.Drawing.Point(167, 271);
            this.lbNameMovie.Name = "lbNameMovie";
            this.lbNameMovie.Size = new System.Drawing.Size(70, 25);
            this.lbNameMovie.TabIndex = 1;
            this.lbNameMovie.Text = "label1";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnBuyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyTicket.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.White;
            this.btnBuyTicket.Location = new System.Drawing.Point(139, 106);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(128, 47);
            this.btnBuyTicket.TabIndex = 3;
            this.btnBuyTicket.Text = "BUY TICKET";
            this.btnBuyTicket.UseVisualStyleBackColor = false;
            // 
            // UcItemMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.lbNameMovie);
            this.Controls.Add(this.pbxMovie);
            this.Name = "UcItemMovie";
            this.Size = new System.Drawing.Size(421, 308);
            this.Load += new System.EventHandler(this.UcItemMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMovie;
        private System.Windows.Forms.Label lbNameMovie;
        private System.Windows.Forms.Button btnBuyTicket;
    }
}
