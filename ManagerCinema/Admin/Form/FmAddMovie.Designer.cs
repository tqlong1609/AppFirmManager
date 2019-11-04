namespace ManagerCinema
{
    partial class FmAddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAddMovie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.txxName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtDirector = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtCountry = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtProducer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtActor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtTime = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.ddwType = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpkDateShowing = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtTimeStart = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 3);
            this.panel1.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(817, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 24;
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
            this.btnMinScreen.Location = new System.Drawing.Point(781, 12);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 23;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(12, 55);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(424, 272);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 26;
            this.pbxImage.TabStop = false;
            // 
            // txxName
            // 
            this.txxName.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txxName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txxName.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txxName.BorderThickness = 3;
            this.txxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txxName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txxName.ForeColor = System.Drawing.Color.Silver;
            this.txxName.isPassword = false;
            this.txxName.Location = new System.Drawing.Point(454, 55);
            this.txxName.Margin = new System.Windows.Forms.Padding(4);
            this.txxName.Name = "txxName";
            this.txxName.Size = new System.Drawing.Size(391, 51);
            this.txxName.TabIndex = 69;
            this.txxName.Text = "Name";
            this.txxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtDirector
            // 
            this.txtDirector.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtDirector.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDirector.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtDirector.BorderThickness = 3;
            this.txtDirector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDirector.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDirector.ForeColor = System.Drawing.Color.Silver;
            this.txtDirector.isPassword = false;
            this.txtDirector.Location = new System.Drawing.Point(454, 114);
            this.txtDirector.Margin = new System.Windows.Forms.Padding(4);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(391, 51);
            this.txtDirector.TabIndex = 70;
            this.txtDirector.Text = "Director";
            this.txtDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCountry
            // 
            this.txtCountry.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtCountry.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCountry.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtCountry.BorderThickness = 3;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCountry.ForeColor = System.Drawing.Color.Silver;
            this.txtCountry.isPassword = false;
            this.txtCountry.Location = new System.Drawing.Point(454, 173);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(391, 51);
            this.txtCountry.TabIndex = 71;
            this.txtCountry.Text = "Country";
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtProducer
            // 
            this.txtProducer.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtProducer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtProducer.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtProducer.BorderThickness = 3;
            this.txtProducer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProducer.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtProducer.ForeColor = System.Drawing.Color.Silver;
            this.txtProducer.isPassword = false;
            this.txtProducer.Location = new System.Drawing.Point(454, 232);
            this.txtProducer.Margin = new System.Windows.Forms.Padding(4);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(391, 51);
            this.txtProducer.TabIndex = 72;
            this.txtProducer.Text = "Producer";
            this.txtProducer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtActor
            // 
            this.txtActor.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtActor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtActor.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtActor.BorderThickness = 3;
            this.txtActor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtActor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtActor.ForeColor = System.Drawing.Color.Silver;
            this.txtActor.isPassword = false;
            this.txtActor.Location = new System.Drawing.Point(454, 291);
            this.txtActor.Margin = new System.Windows.Forms.Padding(4);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(391, 51);
            this.txtActor.TabIndex = 73;
            this.txtActor.Text = "Actor";
            this.txtActor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTime
            // 
            this.txtTime.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtTime.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTime.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtTime.BorderThickness = 3;
            this.txtTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTime.ForeColor = System.Drawing.Color.Silver;
            this.txtTime.isPassword = false;
            this.txtTime.Location = new System.Drawing.Point(454, 350);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(391, 51);
            this.txtTime.TabIndex = 74;
            this.txtTime.Text = "Time(thời lượng)";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(456, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 102;
            this.label9.Text = "Type:";
            // 
            // ddwType
            // 
            this.ddwType.BackColor = System.Drawing.Color.Transparent;
            this.ddwType.BorderRadius = 3;
            this.ddwType.ForeColor = System.Drawing.Color.White;
            this.ddwType.Items = new string[] {
        "Action",
        "Horror",
        "Funny"};
            this.ddwType.Location = new System.Drawing.Point(531, 526);
            this.ddwType.Name = "ddwType";
            this.ddwType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ddwType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.ddwType.selectedIndex = -1;
            this.ddwType.Size = new System.Drawing.Size(315, 35);
            this.ddwType.TabIndex = 101;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(457, 579);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(143, 22);
            this.bunifuCustomLabel1.TabIndex = 104;
            this.bunifuCustomLabel1.Text = "Date Showing:";
            // 
            // dpkDateShowing
            // 
            this.dpkDateShowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.dpkDateShowing.BorderRadius = 0;
            this.dpkDateShowing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dpkDateShowing.ForeColor = System.Drawing.Color.White;
            this.dpkDateShowing.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpkDateShowing.FormatCustom = null;
            this.dpkDateShowing.Location = new System.Drawing.Point(601, 567);
            this.dpkDateShowing.Name = "dpkDateShowing";
            this.dpkDateShowing.Size = new System.Drawing.Size(245, 51);
            this.dpkDateShowing.TabIndex = 103;
            this.dpkDateShowing.Value = new System.DateTime(2019, 9, 26, 12, 20, 57, 390);
            // 
            // txtTimeStart
            // 
            this.txtTimeStart.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtTimeStart.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimeStart.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtTimeStart.BorderThickness = 3;
            this.txtTimeStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimeStart.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtTimeStart.ForeColor = System.Drawing.Color.Silver;
            this.txtTimeStart.isPassword = false;
            this.txtTimeStart.Location = new System.Drawing.Point(454, 409);
            this.txtTimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimeStart.Name = "txtTimeStart";
            this.txtTimeStart.Size = new System.Drawing.Size(391, 51);
            this.txtTimeStart.TabIndex = 105;
            this.txtTimeStart.Text = "Time start";
            this.txtTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColorFocused = System.Drawing.Color.LightSlateGray;
            this.txtPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.BorderColorMouseHover = System.Drawing.Color.LightSlateGray;
            this.txtPrice.BorderThickness = 3;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.Silver;
            this.txtPrice.isPassword = false;
            this.txtPrice.Location = new System.Drawing.Point(454, 468);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(391, 51);
            this.txtPrice.TabIndex = 106;
            this.txtPrice.Text = "Price";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rtxtContent
            // 
            this.rtxtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.rtxtContent.ForeColor = System.Drawing.SystemColors.Info;
            this.rtxtContent.Location = new System.Drawing.Point(12, 393);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(424, 225);
            this.rtxtContent.TabIndex = 107;
            this.rtxtContent.Text = "Content";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageActive = null;
            this.btnLoad.Location = new System.Drawing.Point(199, 333);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(49, 43);
            this.btnLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLoad.TabIndex = 108;
            this.btnLoad.TabStop = false;
            this.btnLoad.Zoom = 10;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.btnSave.Location = new System.Drawing.Point(287, 646);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(282, 41);
            this.btnSave.TabIndex = 109;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(858, 702);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTimeStart);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.dpkDateShowing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ddwType);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtActor);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txxName);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmAddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmAddMovie";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmAddMovie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmAddMovie_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmAddMovie_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private System.Windows.Forms.PictureBox pbxImage;
        private Bunifu.Framework.UI.BunifuMetroTextbox txxName;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtDirector;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtCountry;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtProducer;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtActor;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTime;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuDropdown ddwType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDatepicker dpkDateShowing;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtTimeStart;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrice;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private Bunifu.Framework.UI.BunifuImageButton btnLoad;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
    }
}