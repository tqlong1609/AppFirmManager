using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmProfile : FormMain
    {
        public FmProfile()
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

        private void FmProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmProfile_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
    }
}
