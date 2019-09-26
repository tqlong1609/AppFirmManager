using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmHomeUser : FormMain
    {

        public FmHomeUser()
        {
            InitializeComponent();
        }

        private void FmHomeUser_Load(object sender, EventArgs e)
        {
            flpBackground.Controls.Add(new UcDetailMovie(new Movie(Image.FromFile("Image//image5.jpg"), "ALLADIN VÀ CÂY ĐÈN THẦN")));
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmHomeUser_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmHomeUser_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmHomeUser_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
    }
}
