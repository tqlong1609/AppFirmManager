namespace ManagerCinema
{
    partial class UcListSeat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcListSeat));
            this.gvwSeat = new System.Windows.Forms.DataGridView();
            this.cbxRoom = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvwSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwSeat
            // 
            this.gvwSeat.AllowUserToAddRows = false;
            this.gvwSeat.AllowUserToResizeColumns = false;
            this.gvwSeat.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.gvwSeat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvwSeat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvwSeat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.gvwSeat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwSeat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gvwSeat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwSeat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvwSeat.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvwSeat.EnableHeadersVisualStyles = false;
            this.gvwSeat.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gvwSeat.Location = new System.Drawing.Point(3, 52);
            this.gvwSeat.MultiSelect = false;
            this.gvwSeat.Name = "gvwSeat";
            this.gvwSeat.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwSeat.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvwSeat.RowHeadersVisible = false;
            this.gvwSeat.RowTemplate.Height = 30;
            this.gvwSeat.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvwSeat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvwSeat.Size = new System.Drawing.Size(859, 526);
            this.gvwSeat.TabIndex = 32;
            this.gvwSeat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwSeat_CellClick);
            // 
            // cbxRoom
            // 
            this.cbxRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbxRoom.BorderRadius = 3;
            this.cbxRoom.ForeColor = System.Drawing.Color.White;
            this.cbxRoom.Items = new string[0];
            this.cbxRoom.Location = new System.Drawing.Point(563, 7);
            this.cbxRoom.Name = "cbxRoom";
            this.cbxRoom.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cbxRoom.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cbxRoom.selectedIndex = -1;
            this.cbxRoom.Size = new System.Drawing.Size(169, 35);
            this.cbxRoom.TabIndex = 104;
            this.cbxRoom.onItemSelected += new System.EventHandler(this.cbxRoom_onItemSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(485, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 105;
            this.label1.Text = "Room:";
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.ActiveBorderThickness = 1;
            this.btnAddRoom.ActiveCornerRadius = 20;
            this.btnAddRoom.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))));
            this.btnAddRoom.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.ActiveLineColor = System.Drawing.Color.Red;
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnAddRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.BackgroundImage")));
            this.btnAddRoom.ButtonText = "Add Room";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.IdleBorderThickness = 1;
            this.btnAddRoom.IdleCornerRadius = 20;
            this.btnAddRoom.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))));
            this.btnAddRoom.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddRoom.Location = new System.Drawing.Point(737, 2);
            this.btnAddRoom.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(123, 41);
            this.btnAddRoom.TabIndex = 113;
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(563, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 55);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 28;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(242, 583);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 55);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 27;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UcListSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxRoom);
            this.Controls.Add(this.gvwSeat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "UcListSeat";
            this.Size = new System.Drawing.Size(865, 641);
            this.Load += new System.EventHandler(this.UcListSeat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private System.Windows.Forms.DataGridView gvwSeat;
        private Bunifu.Framework.UI.BunifuDropdown cbxRoom;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddRoom;
    }
}
