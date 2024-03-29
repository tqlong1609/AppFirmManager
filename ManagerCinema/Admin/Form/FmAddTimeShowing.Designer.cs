﻿namespace ManagerCinema
{
    partial class FmAddTimeShowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAddTimeShowing));
            this.label9 = new System.Windows.Forms.Label();
            this.cbxMovie = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCinema = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRoomCinema = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.dpkDateShowing = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpkTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(56, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 102;
            this.label9.Text = "Movies:";
            // 
            // cbxMovie
            // 
            this.cbxMovie.BackColor = System.Drawing.Color.Transparent;
            this.cbxMovie.BorderRadius = 3;
            this.cbxMovie.ForeColor = System.Drawing.Color.White;
            this.cbxMovie.Items = new string[0];
            this.cbxMovie.Location = new System.Drawing.Point(168, 76);
            this.cbxMovie.Name = "cbxMovie";
            this.cbxMovie.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxMovie.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxMovie.selectedIndex = -1;
            this.cbxMovie.Size = new System.Drawing.Size(315, 35);
            this.cbxMovie.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "Cinema:";
            // 
            // cbxCinema
            // 
            this.cbxCinema.BackColor = System.Drawing.Color.Transparent;
            this.cbxCinema.BorderRadius = 3;
            this.cbxCinema.ForeColor = System.Drawing.Color.White;
            this.cbxCinema.Items = new string[0];
            this.cbxCinema.Location = new System.Drawing.Point(168, 136);
            this.cbxCinema.Name = "cbxCinema";
            this.cbxCinema.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxCinema.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxCinema.selectedIndex = -1;
            this.cbxCinema.Size = new System.Drawing.Size(315, 35);
            this.cbxCinema.TabIndex = 103;
            this.cbxCinema.onItemSelected += new System.EventHandler(this.cbxCinema_onItemSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(56, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 106;
            this.label2.Text = "Room:";
            // 
            // cbxRoomCinema
            // 
            this.cbxRoomCinema.BackColor = System.Drawing.Color.Transparent;
            this.cbxRoomCinema.BorderRadius = 3;
            this.cbxRoomCinema.ForeColor = System.Drawing.Color.White;
            this.cbxRoomCinema.Items = new string[0];
            this.cbxRoomCinema.Location = new System.Drawing.Point(168, 193);
            this.cbxRoomCinema.Name = "cbxRoomCinema";
            this.cbxRoomCinema.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxRoomCinema.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxRoomCinema.selectedIndex = -1;
            this.cbxRoomCinema.Size = new System.Drawing.Size(315, 35);
            this.cbxRoomCinema.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(56, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 108;
            this.label3.Text = "Time";
            // 
            // dpkDateShowing
            // 
            this.dpkDateShowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.dpkDateShowing.BorderRadius = 0;
            this.dpkDateShowing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpkDateShowing.ForeColor = System.Drawing.Color.White;
            this.dpkDateShowing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkDateShowing.FormatCustom = null;
            this.dpkDateShowing.Location = new System.Drawing.Point(168, 302);
            this.dpkDateShowing.Name = "dpkDateShowing";
            this.dpkDateShowing.Size = new System.Drawing.Size(199, 43);
            this.dpkDateShowing.TabIndex = 107;
            this.dpkDateShowing.Value = new System.DateTime(2019, 9, 26, 12, 20, 57, 390);
            // 
            // dpkTime
            // 
            this.dpkTime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dpkTime.CustomFormat = "HH:mm";
            this.dpkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkTime.Location = new System.Drawing.Point(168, 260);
            this.dpkTime.Name = "dpkTime";
            this.dpkTime.ShowUpDown = true;
            this.dpkTime.Size = new System.Drawing.Size(62, 20);
            this.dpkTime.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(61, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 111;
            this.label4.Text = "Date:";
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.ActiveLineColor = System.Drawing.Color.Red;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Location = new System.Drawing.Point(147, 381);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(282, 41);
            this.btnSave.TabIndex = 112;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(510, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 114;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinScreen
            // 
            this.btnMinScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnMinScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinScreen.Image = global::ManagerCinema.Properties.Resources.minus_127px;
            this.btnMinScreen.ImageActive = null;
            this.btnMinScreen.Location = new System.Drawing.Point(474, 12);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 113;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // FmAddTimeShowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(550, 445);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpkTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpkDateShowing);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxRoomCinema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxCinema);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbxMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddTimeShowing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmAddTimeShowing";
            this.Load += new System.EventHandler(this.FmAddTimeShowing_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmAddTimeShowing_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmAddTimeShowing_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmAddTimeShowing_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown cbxMovie;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cbxCinema;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown cbxRoomCinema;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateShowing;
        private System.Windows.Forms.DateTimePicker dpkTime;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
    }
}