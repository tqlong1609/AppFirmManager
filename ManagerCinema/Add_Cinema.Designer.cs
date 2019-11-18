namespace ManagerCinema
{
    partial class Add_Cinema
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idCinema";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(193, 20);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 52);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 78);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(108, 104);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(193, 20);
            this.txtNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Room";
            // 
            // txtOpen
            // 
            this.txtOpen.Location = new System.Drawing.Point(108, 130);
            this.txtOpen.Name = "txtOpen";
            this.txtOpen.Size = new System.Drawing.Size(193, 20);
            this.txtOpen.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Open";
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(108, 156);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(193, 20);
            this.txtClose.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Close";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 237);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOpen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Add_Movie";
            this.Text = "Add_Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}