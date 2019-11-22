namespace ManagerCinema
{
    partial class FmAddCinema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAddCinema));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dpkTimeOpen = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkTimeClose = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(490, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 26;
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
            this.btnMinScreen.Location = new System.Drawing.Point(454, 12);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 25;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 121;
            this.label1.Text = "Name:";
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
            this.txtName.Location = new System.Drawing.Point(204, 72);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 51);
            this.txtName.TabIndex = 120;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(75, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 123;
            this.label2.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.Silver;
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(204, 140);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(278, 51);
            this.txtAddress.TabIndex = 122;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dpkTimeOpen
            // 
            this.dpkTimeOpen.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dpkTimeOpen.CustomFormat = "HH:mm";
            this.dpkTimeOpen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkTimeOpen.Location = new System.Drawing.Point(204, 221);
            this.dpkTimeOpen.Name = "dpkTimeOpen";
            this.dpkTimeOpen.ShowUpDown = true;
            this.dpkTimeOpen.Size = new System.Drawing.Size(62, 20);
            this.dpkTimeOpen.TabIndex = 124;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 125;
            this.label3.Text = "Time Open:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(75, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 127;
            this.label4.Text = "Time Close:";
            // 
            // dpkTimeClose
            // 
            this.dpkTimeClose.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.dpkTimeClose.CustomFormat = "HH:mm";
            this.dpkTimeClose.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkTimeClose.Location = new System.Drawing.Point(204, 265);
            this.dpkTimeClose.Name = "dpkTimeClose";
            this.dpkTimeClose.ShowUpDown = true;
            this.dpkTimeClose.Size = new System.Drawing.Size(62, 20);
            this.dpkTimeClose.TabIndex = 126;
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
            this.btnSave.Location = new System.Drawing.Point(130, 333);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(282, 41);
            this.btnSave.TabIndex = 128;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FmAddCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(540, 394);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpkTimeClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dpkTimeOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAddCinema";
            this.Load += new System.EventHandler(this.FmAddCinema_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmAddCinema_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmAddCinema_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmAddCinema_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private System.Windows.Forms.DateTimePicker dpkTimeOpen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpkTimeClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
    }
}