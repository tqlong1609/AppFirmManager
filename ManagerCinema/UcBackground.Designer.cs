namespace ManagerCinema
{
    partial class UcBackground
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBackground));
            this.btnLeft = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRight = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).BeginInit();
            this.pnlBackground.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.ImageActive = null;
            this.btnLeft.Location = new System.Drawing.Point(3, 133);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(65, 71);
            this.btnLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLeft.TabIndex = 3;
            this.btnLeft.TabStop = false;
            this.btnLeft.Zoom = 10;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.ImageActive = null;
            this.btnRight.Location = new System.Drawing.Point(1224, 133);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(65, 71);
            this.btnRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRight.TabIndex = 4;
            this.btnRight.TabStop = false;
            this.btnRight.Zoom = 10;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Controls.Add(this.btnLeft);
            this.pnlBackground.Controls.Add(this.btnRight);
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1302, 323);
            this.pnlBackground.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(900, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 297);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUA VÉ NHANH";
            // 
            // UcBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.Controls.Add(this.pnlBackground);
            this.Name = "UcBackground";
            this.Size = new System.Drawing.Size(1302, 323);
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).EndInit();
            this.pnlBackground.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnLeft;
        private Bunifu.Framework.UI.BunifuImageButton btnRight;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
