namespace ManagerCinema
{
    partial class FmBookticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBookticket));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.label9 = new System.Windows.Forms.Label();
            this.city_drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.date_drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time_drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.timeshow_drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.seat_drop = new Bunifu.Framework.UI.BunifuDropdown();
            this.room_drop = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cinema_drop = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.movie_drop = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.money_drop = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(523, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinScreen
            // 
            this.btnMinScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnMinScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinScreen.Image = global::ManagerCinema.Properties.Resources.minus_127px;
            this.btnMinScreen.ImageActive = null;
            this.btnMinScreen.Location = new System.Drawing.Point(487, 2);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 26;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(36, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 100;
            this.label9.Text = "City:";
            // 
            // city_drop
            // 
            this.city_drop.BackColor = System.Drawing.Color.Transparent;
            this.city_drop.BorderRadius = 3;
            this.city_drop.ForeColor = System.Drawing.Color.White;
            this.city_drop.Items = new string[] {
        "Tp Hồ Chí Minh",
        "Tp Đà Nẵng",
        "Tp Hà Nội"};
            this.city_drop.Location = new System.Drawing.Point(167, 180);
            this.city_drop.Name = "city_drop";
            this.city_drop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.city_drop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.city_drop.selectedIndex = -1;
            this.city_drop.Size = new System.Drawing.Size(315, 35);
            this.city_drop.TabIndex = 99;
            // 
            // date_drop
            // 
            this.date_drop.BackColor = System.Drawing.Color.Transparent;
            this.date_drop.BorderRadius = 3;
            this.date_drop.ForeColor = System.Drawing.Color.White;
            this.date_drop.Items = new string[] {
        "30-09-2019"};
            this.date_drop.Location = new System.Drawing.Point(167, 385);
            this.date_drop.Name = "date_drop";
            this.date_drop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.date_drop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.date_drop.selectedIndex = -1;
            this.date_drop.Size = new System.Drawing.Size(315, 35);
            this.date_drop.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(36, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 97;
            this.label3.Text = "Time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 96;
            this.label2.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 95;
            this.label1.Text = "Cinema:";
            // 
            // time_drop
            // 
            this.time_drop.BackColor = System.Drawing.Color.Transparent;
            this.time_drop.BorderRadius = 3;
            this.time_drop.ForeColor = System.Drawing.Color.White;
            this.time_drop.Items = new string[] {
        "11:30"};
            this.time_drop.Location = new System.Drawing.Point(167, 426);
            this.time_drop.Name = "time_drop";
            this.time_drop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.time_drop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.time_drop.selectedIndex = -1;
            this.time_drop.Size = new System.Drawing.Size(315, 35);
            this.time_drop.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 102;
            this.label4.Text = "Movie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(36, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 104;
            this.label5.Text = "Money:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(185, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 31);
            this.label8.TabIndex = 105;
            this.label8.Text = "BUY TICKET";
            // 
            // btnLogin
            // 
            this.btnLogin.ActiveBorderThickness = 1;
            this.btnLogin.ActiveCornerRadius = 20;
            this.btnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.btnLogin.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnLogin.ActiveLineColor = System.Drawing.Color.Red;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.ButtonText = "Confirm";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleCornerRadius = 20;
            this.btnLogin.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Location = new System.Drawing.Point(157, 528);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(239, 48);
            this.btnLogin.TabIndex = 106;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(36, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 107;
            this.label6.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtUsername.BorderThickness = 3;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(167, 98);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 34);
            this.txtUsername.TabIndex = 108;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(36, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 110;
            this.label7.Text = "Room:";
            // 
            // timeshow_drop
            // 
            this.timeshow_drop.BackColor = System.Drawing.Color.Transparent;
            this.timeshow_drop.BorderRadius = 3;
            this.timeshow_drop.ForeColor = System.Drawing.Color.White;
            this.timeshow_drop.Items = new string[] {
        "Vincom thu duc"};
            this.timeshow_drop.Location = new System.Drawing.Point(167, 344);
            this.timeshow_drop.Name = "timeshow_drop";
            this.timeshow_drop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.timeshow_drop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.timeshow_drop.selectedIndex = -1;
            this.timeshow_drop.Size = new System.Drawing.Size(315, 35);
            this.timeshow_drop.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(36, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 25);
            this.label10.TabIndex = 112;
            this.label10.Text = "Time Show:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(36, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 25);
            this.label11.TabIndex = 114;
            this.label11.Text = "Seat";
            // 
            // seat_drop
            // 
            this.seat_drop.BackColor = System.Drawing.Color.Transparent;
            this.seat_drop.BorderRadius = 3;
            this.seat_drop.ForeColor = System.Drawing.Color.White;
            this.seat_drop.Items = new string[] {
        "Vincom thu duc"};
            this.seat_drop.Location = new System.Drawing.Point(167, 303);
            this.seat_drop.Name = "seat_drop";
            this.seat_drop.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.seat_drop.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.seat_drop.selectedIndex = -1;
            this.seat_drop.Size = new System.Drawing.Size(315, 35);
            this.seat_drop.TabIndex = 113;
            // 
            // room_drop
            // 
            this.room_drop.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.room_drop.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.room_drop.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.room_drop.BorderThickness = 3;
            this.room_drop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.room_drop.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.room_drop.ForeColor = System.Drawing.Color.Silver;
            this.room_drop.isPassword = false;
            this.room_drop.Location = new System.Drawing.Point(167, 139);
            this.room_drop.Margin = new System.Windows.Forms.Padding(4);
            this.room_drop.Name = "room_drop";
            this.room_drop.Size = new System.Drawing.Size(315, 34);
            this.room_drop.TabIndex = 115;
            this.room_drop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cinema_drop
            // 
            this.cinema_drop.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.cinema_drop.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cinema_drop.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.cinema_drop.BorderThickness = 3;
            this.cinema_drop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cinema_drop.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cinema_drop.ForeColor = System.Drawing.Color.Silver;
            this.cinema_drop.isPassword = false;
            this.cinema_drop.Location = new System.Drawing.Point(167, 221);
            this.cinema_drop.Margin = new System.Windows.Forms.Padding(4);
            this.cinema_drop.Name = "cinema_drop";
            this.cinema_drop.Size = new System.Drawing.Size(315, 34);
            this.cinema_drop.TabIndex = 116;
            this.cinema_drop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // movie_drop
            // 
            this.movie_drop.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.movie_drop.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.movie_drop.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.movie_drop.BorderThickness = 3;
            this.movie_drop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movie_drop.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.movie_drop.ForeColor = System.Drawing.Color.Silver;
            this.movie_drop.isPassword = false;
            this.movie_drop.Location = new System.Drawing.Point(167, 262);
            this.movie_drop.Margin = new System.Windows.Forms.Padding(4);
            this.movie_drop.Name = "movie_drop";
            this.movie_drop.Size = new System.Drawing.Size(315, 34);
            this.movie_drop.TabIndex = 117;
            this.movie_drop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // money_drop
            // 
            this.money_drop.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.money_drop.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.money_drop.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.money_drop.BorderThickness = 3;
            this.money_drop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.money_drop.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.money_drop.ForeColor = System.Drawing.Color.Silver;
            this.money_drop.isPassword = false;
            this.money_drop.Location = new System.Drawing.Point(167, 463);
            this.money_drop.Margin = new System.Windows.Forms.Padding(4);
            this.money_drop.Name = "money_drop";
            this.money_drop.Size = new System.Drawing.Size(315, 34);
            this.money_drop.TabIndex = 118;
            this.money_drop.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FmBookticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(553, 601);
            this.Controls.Add(this.money_drop);
            this.Controls.Add(this.movie_drop);
            this.Controls.Add(this.cinema_drop);
            this.Controls.Add(this.room_drop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.seat_drop);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.timeshow_drop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.city_drop);
            this.Controls.Add(this.date_drop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time_drop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmBookticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmBookticket";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmBookticket_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmBookticket_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmBookticket_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown city_drop;
        private Bunifu.Framework.UI.BunifuDropdown date_drop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown time_drop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogin;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDropdown timeshow_drop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuDropdown seat_drop;
        private Bunifu.Framework.UI.BunifuMetroTextbox room_drop;
        private Bunifu.Framework.UI.BunifuMetroTextbox cinema_drop;
        private Bunifu.Framework.UI.BunifuMetroTextbox movie_drop;
        private Bunifu.Framework.UI.BunifuMetroTextbox money_drop;
    }
}