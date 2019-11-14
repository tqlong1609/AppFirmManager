namespace ManagerCinema
{
    partial class FmTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTicket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCinema = new Bunifu.Framework.UI.BunifuDropdown();
            this.cbxTime = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDate = new Bunifu.Framework.UI.BunifuDropdown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxCity = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuyTicket = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 5);
            this.panel1.TabIndex = 47;
            // 
            // cbxCinema
            // 
            this.cbxCinema.BackColor = System.Drawing.Color.Transparent;
            this.cbxCinema.BorderRadius = 3;
            this.cbxCinema.ForeColor = System.Drawing.Color.White;
            this.cbxCinema.Items = new string[0];
            this.cbxCinema.Location = new System.Drawing.Point(164, 146);
            this.cbxCinema.Name = "cbxCinema";
            this.cbxCinema.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxCinema.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxCinema.selectedIndex = -1;
            this.cbxCinema.Size = new System.Drawing.Size(315, 35);
            this.cbxCinema.TabIndex = 48;
            this.cbxCinema.onItemSelected += new System.EventHandler(this.cbxCinema_onItemSelected);
            // 
            // cbxTime
            // 
            this.cbxTime.BackColor = System.Drawing.Color.Transparent;
            this.cbxTime.BorderRadius = 3;
            this.cbxTime.ForeColor = System.Drawing.Color.White;
            this.cbxTime.Items = new string[0];
            this.cbxTime.Location = new System.Drawing.Point(164, 259);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxTime.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxTime.selectedIndex = -1;
            this.cbxTime.Size = new System.Drawing.Size(315, 35);
            this.cbxTime.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cinema:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 53;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(65, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Time:";
            // 
            // cbxDate
            // 
            this.cbxDate.BackColor = System.Drawing.Color.Transparent;
            this.cbxDate.BorderRadius = 3;
            this.cbxDate.ForeColor = System.Drawing.Color.White;
            this.cbxDate.Items = new string[0];
            this.cbxDate.Location = new System.Drawing.Point(164, 202);
            this.cbxDate.Name = "cbxDate";
            this.cbxDate.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxDate.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxDate.selectedIndex = -1;
            this.cbxDate.Size = new System.Drawing.Size(315, 35);
            this.cbxDate.TabIndex = 55;
            this.cbxDate.onItemSelected += new System.EventHandler(this.cbxDate_onItemSelected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(205, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 33);
            this.label8.TabIndex = 59;
            this.label8.Text = "BUY TICKET";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(65, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 61;
            this.label9.Text = "City:";
            // 
            // cbxCity
            // 
            this.cbxCity.BackColor = System.Drawing.Color.Transparent;
            this.cbxCity.BorderRadius = 3;
            this.cbxCity.ForeColor = System.Drawing.Color.White;
            this.cbxCity.Items = new string[0];
            this.cbxCity.Location = new System.Drawing.Point(164, 89);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxCity.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxCity.selectedIndex = -1;
            this.cbxCity.Size = new System.Drawing.Size(315, 35);
            this.cbxCity.TabIndex = 60;
            this.cbxCity.onItemSelected += new System.EventHandler(this.cbxCity_onItemSelected);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(3, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 29);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 58;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.ActiveBorderThickness = 1;
            this.btnBuyTicket.ActiveCornerRadius = 20;
            this.btnBuyTicket.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnBuyTicket.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnBuyTicket.ActiveLineColor = System.Drawing.Color.Red;
            this.btnBuyTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuyTicket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuyTicket.BackgroundImage")));
            this.btnBuyTicket.ButtonText = "NEXT";
            this.btnBuyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyTicket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTicket.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBuyTicket.IdleBorderThickness = 1;
            this.btnBuyTicket.IdleCornerRadius = 20;
            this.btnBuyTicket.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnBuyTicket.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBuyTicket.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBuyTicket.Location = new System.Drawing.Point(164, 348);
            this.btnBuyTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(264, 52);
            this.btnBuyTicket.TabIndex = 57;
            this.btnBuyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(572, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 46;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = global::ManagerCinema.Properties.Resources.minus_127px;
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(536, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 29);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 45;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // FmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(612, 414);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.cbxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTime);
            this.Controls.Add(this.cbxCinema);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmTicket";
            this.Load += new System.EventHandler(this.FmTicket_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmTicket_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmTicket_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmTicket_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
        private Bunifu.Framework.UI.BunifuDropdown cbxCinema;
        private Bunifu.Framework.UI.BunifuDropdown cbxTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDropdown cbxDate;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBuyTicket;
        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown cbxCity;
    }
}