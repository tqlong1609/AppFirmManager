namespace ManagerCinema
{
    partial class FmLogin
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbLoginT = new System.Windows.Forms.Label();
            this.lbRegisterT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinScreen = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.Color.Gray;
            this.lbLogin.Location = new System.Drawing.Point(54, 71);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(85, 33);
            this.lbLogin.TabIndex = 9;
            this.lbLogin.Text = "Login";
            this.lbLogin.Click += new System.EventHandler(this.lbLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(129, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "/";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegister.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.Gray;
            this.lbRegister.Location = new System.Drawing.Point(147, 71);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(119, 33);
            this.lbRegister.TabIndex = 11;
            this.lbRegister.Text = "Register";
            this.lbRegister.Click += new System.EventHandler(this.lbRegister_Click);
            // 
            // lbLoginT
            // 
            this.lbLoginT.AutoSize = true;
            this.lbLoginT.ForeColor = System.Drawing.Color.Gray;
            this.lbLoginT.Location = new System.Drawing.Point(64, 104);
            this.lbLoginT.Name = "lbLoginT";
            this.lbLoginT.Size = new System.Drawing.Size(61, 13);
            this.lbLoginT.TabIndex = 12;
            this.lbLoginT.Text = "_________";
            // 
            // lbRegisterT
            // 
            this.lbRegisterT.AutoSize = true;
            this.lbRegisterT.ForeColor = System.Drawing.Color.Gray;
            this.lbRegisterT.Location = new System.Drawing.Point(157, 104);
            this.lbRegisterT.Name = "lbRegisterT";
            this.lbRegisterT.Size = new System.Drawing.Size(91, 13);
            this.lbRegisterT.TabIndex = 13;
            this.lbRegisterT.Text = "______________";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 5);
            this.panel1.TabIndex = 16;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Location = new System.Drawing.Point(0, 134);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(573, 269);
            this.pnlBackground.TabIndex = 17;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::ManagerCinema.Properties.Resources.delete_sign_filled_127px;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(540, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
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
            this.btnMinScreen.Location = new System.Drawing.Point(504, 4);
            this.btnMinScreen.Name = "btnMinScreen";
            this.btnMinScreen.Size = new System.Drawing.Size(28, 29);
            this.btnMinScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinScreen.TabIndex = 4;
            this.btnMinScreen.TabStop = false;
            this.btnMinScreen.Zoom = 10;
            this.btnMinScreen.Click += new System.EventHandler(this.btnMinScreen_Click);
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(577, 407);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbRegisterT);
            this.Controls.Add(this.lbLoginT);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmLogin";
            this.Load += new System.EventHandler(this.FmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FmLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FmLogin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnMinScreen;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbLoginT;
        private System.Windows.Forms.Label lbRegisterT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBackground;
    }
}