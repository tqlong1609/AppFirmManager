﻿namespace ManagerCinema
{
    partial class FmReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmReview));
            this.btnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxMovie = new System.Windows.Forms.PictureBox();
            this.lbNameMovie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxSeat = new System.Windows.Forms.ListBox();
            this.lbCinema = new System.Windows.Forms.Label();
            this.lbShowtime = new System.Windows.Forms.Label();
            this.lbTicket = new System.Windows.Forms.Label();
            this.lbSumMonney = new System.Windows.Forms.Label();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageActive = null;
            this.btnBack.Location = new System.Drawing.Point(5, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 29);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 61;
            this.btnBack.TabStop = false;
            this.btnBack.Zoom = 10;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(608, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 60;
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
            this.btnMini.Location = new System.Drawing.Point(572, 12);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 29);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 59;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 5);
            this.panel2.TabIndex = 63;
            // 
            // pbxMovie
            // 
            this.pbxMovie.Location = new System.Drawing.Point(5, 47);
            this.pbxMovie.Name = "pbxMovie";
            this.pbxMovie.Size = new System.Drawing.Size(257, 291);
            this.pbxMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMovie.TabIndex = 64;
            this.pbxMovie.TabStop = false;
            // 
            // lbNameMovie
            // 
            this.lbNameMovie.AutoSize = true;
            this.lbNameMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNameMovie.Location = new System.Drawing.Point(268, 47);
            this.lbNameMovie.MaximumSize = new System.Drawing.Size(400, 100);
            this.lbNameMovie.Name = "lbNameMovie";
            this.lbNameMovie.Size = new System.Drawing.Size(368, 58);
            this.lbNameMovie.TabIndex = 65;
            this.lbNameMovie.Text = "Name Movie Name Movie Name Movie Name Movie Name Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(268, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Cinema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(269, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Showtime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(269, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Seat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(269, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ticket:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(268, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Sum Monney:";
            // 
            // lbxSeat
            // 
            this.lbxSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbxSeat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxSeat.ColumnWidth = 30;
            this.lbxSeat.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSeat.ForeColor = System.Drawing.SystemColors.Info;
            this.lbxSeat.FormattingEnabled = true;
            this.lbxSeat.ItemHeight = 16;
            this.lbxSeat.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B3",
            "B4",
            "B5"});
            this.lbxSeat.Location = new System.Drawing.Point(322, 178);
            this.lbxSeat.MultiColumn = true;
            this.lbxSeat.Name = "lbxSeat";
            this.lbxSeat.Size = new System.Drawing.Size(189, 98);
            this.lbxSeat.TabIndex = 86;
            // 
            // lbCinema
            // 
            this.lbCinema.AutoSize = true;
            this.lbCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCinema.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCinema.Location = new System.Drawing.Point(380, 117);
            this.lbCinema.Name = "lbCinema";
            this.lbCinema.Size = new System.Drawing.Size(21, 20);
            this.lbCinema.TabIndex = 87;
            this.lbCinema.Text = "...";
            // 
            // lbShowtime
            // 
            this.lbShowtime.AutoSize = true;
            this.lbShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowtime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbShowtime.Location = new System.Drawing.Point(380, 149);
            this.lbShowtime.Name = "lbShowtime";
            this.lbShowtime.Size = new System.Drawing.Size(21, 20);
            this.lbShowtime.TabIndex = 88;
            this.lbShowtime.Text = "...";
            // 
            // lbTicket
            // 
            this.lbTicket.AutoSize = true;
            this.lbTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicket.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTicket.Location = new System.Drawing.Point(380, 288);
            this.lbTicket.Name = "lbTicket";
            this.lbTicket.Size = new System.Drawing.Size(21, 20);
            this.lbTicket.TabIndex = 89;
            this.lbTicket.Text = "...";
            // 
            // lbSumMonney
            // 
            this.lbSumMonney.AutoSize = true;
            this.lbSumMonney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumMonney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbSumMonney.Location = new System.Drawing.Point(380, 318);
            this.lbSumMonney.Name = "lbSumMonney";
            this.lbSumMonney.Size = new System.Drawing.Size(96, 20);
            this.lbSumMonney.TabIndex = 90;
            this.lbSumMonney.Text = "50.000 VND";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.Red;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnConfirm.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(164, 347);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(323, 71);
            this.btnConfirm.TabIndex = 91;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(648, 426);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbSumMonney);
            this.Controls.Add(this.lbTicket);
            this.Controls.Add(this.lbShowtime);
            this.Controls.Add(this.lbCinema);
            this.Controls.Add(this.lbxSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameMovie);
            this.Controls.Add(this.pbxMovie);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmReview";
            this.Load += new System.EventHandler(this.FmReview_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmReview_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmReview_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmReview_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnBack;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMini;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxMovie;
        private System.Windows.Forms.Label lbNameMovie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxSeat;
        private System.Windows.Forms.Label lbCinema;
        private System.Windows.Forms.Label lbShowtime;
        private System.Windows.Forms.Label lbTicket;
        private System.Windows.Forms.Label lbSumMonney;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
    }
}