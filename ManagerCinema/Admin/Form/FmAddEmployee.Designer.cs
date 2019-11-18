namespace ManagerCinema
{
    partial class FmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAddEmployee));
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbxImage = new ManagerCinema.ObjectFolder.Grapichs.CirclePictureBox();
            this.btnLoad = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentityCard = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpkDateBorn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpkDateStart = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ddwPosition = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(696, 12);
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
            this.btnMinScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinScreen.Image = global::ManagerCinema.Properties.Resources.minus_127px;
            this.btnMinScreen.ImageActive = null;
            this.btnMinScreen.Location = new System.Drawing.Point(660, 12);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 26;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.White;
            this.pbxImage.Location = new System.Drawing.Point(12, 84);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(244, 201);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 28;
            this.pbxImage.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageActive = null;
            this.btnLoad.Location = new System.Drawing.Point(110, 291);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(49, 43);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoad.TabIndex = 109;
            this.btnLoad.TabStop = false;
            this.btnLoad.Zoom = 10;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(339, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 111;
            this.label5.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtName.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtName.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.SeaShell;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(453, 84);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 51);
            this.txtName.TabIndex = 110;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(339, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.SeaShell;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(453, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 51);
            this.txtEmail.TabIndex = 112;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(339, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtAddress.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtAddress.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.SeaShell;
            this.txtAddress.isPassword = false;
            this.txtAddress.Location = new System.Drawing.Point(453, 202);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 51);
            this.txtAddress.TabIndex = 114;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(339, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 117;
            this.label3.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtPhone.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtPhone.BorderThickness = 3;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.SeaShell;
            this.txtPhone.isPassword = false;
            this.txtPhone.Location = new System.Drawing.Point(453, 261);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 51);
            this.txtPhone.TabIndex = 116;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(339, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalary.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtSalary.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtSalary.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtSalary.BorderThickness = 3;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSalary.ForeColor = System.Drawing.Color.SeaShell;
            this.txtSalary.isPassword = false;
            this.txtSalary.Location = new System.Drawing.Point(453, 320);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(156, 51);
            this.txtSalary.TabIndex = 118;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(339, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 121;
            this.label6.Text = "Identity Card:";
            // 
            // txtIdentityCard
            // 
            this.txtIdentityCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdentityCard.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtIdentityCard.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtIdentityCard.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtIdentityCard.BorderThickness = 3;
            this.txtIdentityCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdentityCard.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdentityCard.ForeColor = System.Drawing.Color.Silver;
            this.txtIdentityCard.isPassword = false;
            this.txtIdentityCard.Location = new System.Drawing.Point(453, 379);
            this.txtIdentityCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdentityCard.Name = "txtIdentityCard";
            this.txtIdentityCard.Size = new System.Drawing.Size(156, 51);
            this.txtIdentityCard.TabIndex = 120;
            this.txtIdentityCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(339, 456);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 22);
            this.bunifuCustomLabel1.TabIndex = 123;
            this.bunifuCustomLabel1.Text = "Date born:";
            // 
            // dpkDateBorn
            // 
            this.dpkDateBorn.AccessibleDescription = "dpkDateBorn";
            this.dpkDateBorn.BackColor = System.Drawing.Color.Gray;
            this.dpkDateBorn.BorderRadius = 0;
            this.dpkDateBorn.ForeColor = System.Drawing.Color.White;
            this.dpkDateBorn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkDateBorn.FormatCustom = null;
            this.dpkDateBorn.Location = new System.Drawing.Point(454, 437);
            this.dpkDateBorn.Name = "dpkDateBorn";
            this.dpkDateBorn.Size = new System.Drawing.Size(235, 51);
            this.dpkDateBorn.TabIndex = 122;
            this.dpkDateBorn.Value = new System.DateTime(2019, 9, 26, 12, 20, 57, 390);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(287, 513);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(155, 22);
            this.bunifuCustomLabel2.TabIndex = 125;
            this.bunifuCustomLabel2.Text = "Date start work:";
            // 
            // dpkDateStart
            // 
            this.dpkDateStart.BackColor = System.Drawing.Color.Gray;
            this.dpkDateStart.BorderRadius = 0;
            this.dpkDateStart.ForeColor = System.Drawing.Color.White;
            this.dpkDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkDateStart.FormatCustom = null;
            this.dpkDateStart.Location = new System.Drawing.Point(453, 494);
            this.dpkDateStart.Name = "dpkDateStart";
            this.dpkDateStart.Size = new System.Drawing.Size(235, 51);
            this.dpkDateStart.TabIndex = 124;
            this.dpkDateStart.Value = new System.DateTime(2019, 9, 26, 12, 20, 57, 390);
            // 
            // ddwPosition
            // 
            this.ddwPosition.BackColor = System.Drawing.Color.Gray;
            this.ddwPosition.BorderRadius = 3;
            this.ddwPosition.ForeColor = System.Drawing.Color.White;
            this.ddwPosition.Items = new string[] {
        "Check ticket",
        "Security",
        "Cell",
        "Marketing",
        "Technical"};
            this.ddwPosition.Location = new System.Drawing.Point(453, 551);
            this.ddwPosition.Name = "ddwPosition";
            this.ddwPosition.NomalColor = System.Drawing.Color.Gray;
            this.ddwPosition.onHoverColor = System.Drawing.Color.Gray;
            this.ddwPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ddwPosition.selectedIndex = -1;
            this.ddwPosition.Size = new System.Drawing.Size(189, 51);
            this.ddwPosition.TabIndex = 126;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(311, 567);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(131, 22);
            this.bunifuCustomLabel3.TabIndex = 127;
            this.bunifuCustomLabel3.Text = "Position work:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.ActiveBorderThickness = 1;
            this.btnConfirm.ActiveCornerRadius = 20;
            this.btnConfirm.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.ActiveForecolor = System.Drawing.Color.DimGray;
            this.btnConfirm.ActiveLineColor = System.Drawing.Color.Red;
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirm.BackgroundImage")));
            this.btnConfirm.ButtonText = "Confirm";
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleBorderThickness = 1;
            this.btnConfirm.IdleCornerRadius = 20;
            this.btnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfirm.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(263, 630);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(239, 48);
            this.btnConfirm.TabIndex = 128;
            this.btnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(736, 701);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.ddwPosition);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dpkDateStart);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dpkDateBorn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdentityCard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmAddEmployee";
            this.Load += new System.EventHandler(this.FmAddEmployee_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmAddEmployee_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmAddEmployee_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmAddEmployee_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private ObjectFolder.Grapichs.CirclePictureBox pbxImage;
        private Bunifu.Framework.UI.BunifuImageButton btnLoad;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAddress;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhone;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtSalary;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdentityCard;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateBorn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateStart;
        private Bunifu.Framework.UI.BunifuDropdown ddwPosition;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConfirm;
    }
}