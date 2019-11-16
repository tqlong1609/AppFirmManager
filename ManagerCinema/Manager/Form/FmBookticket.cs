using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmBookticket : FormMain
    {
        public FmBookticket()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmBookticket_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmBookticket_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmBookticket_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
