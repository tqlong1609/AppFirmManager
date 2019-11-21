namespace ManagerCinema
{
    partial class AddSeat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSeat));
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbxCinema = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRoom = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnAdd.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Red;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Save";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(102, 240);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 41);
            this.btnAdd.TabIndex = 128;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(372, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 127;
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
            this.btnMinScreen.Location = new System.Drawing.Point(336, 12);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 126;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // cbxCinema
            // 
            this.cbxCinema.BackColor = System.Drawing.Color.Transparent;
            this.cbxCinema.BorderRadius = 3;
            this.cbxCinema.ForeColor = System.Drawing.Color.White;
            this.cbxCinema.Items = new string[0];
            this.cbxCinema.Location = new System.Drawing.Point(155, 77);
            this.cbxCinema.Name = "cbxCinema";
            this.cbxCinema.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxCinema.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxCinema.selectedIndex = -1;
            this.cbxCinema.Size = new System.Drawing.Size(223, 35);
            this.cbxCinema.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = "Cinema:";
            // 
            // cbxRoom
            // 
            this.cbxRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbxRoom.BorderRadius = 3;
            this.cbxRoom.ForeColor = System.Drawing.Color.White;
            this.cbxRoom.Items = new string[0];
            this.cbxRoom.Location = new System.Drawing.Point(155, 127);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxRoom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxRoom.selectedIndex = -1;
            this.cbxRoom.Size = new System.Drawing.Size(223, 35);
            this.cbxRoom.TabIndex = 132;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(45, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 131;
            this.label2.Text = "Room:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(45, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 134;
            this.label9.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.Silver;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(152, 169);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 43);
            this.txtName.TabIndex = 133;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AddSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(415, 289);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxCinema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSeat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSeat";
            this.Load += new System.EventHandler(this.AddSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private Bunifu.Framework.UI.BunifuDropdown cbxCinema;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDropdown cbxRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
    }
}