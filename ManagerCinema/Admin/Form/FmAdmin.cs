using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;
using BarcodeLibTest;
namespace ManagerCinema
{
    public partial class FmAdmin : FormMain
    {
        public FmAdmin()
        {
            InitializeComponent();
        }

        private void FmAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListVoucher());
        }


        private void btnListEmployee_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListEmployeeAD());
        }

        private void clearpanel()
        {
            pnlBackground.Controls.Clear();
        }

        private void btnListCinema_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListCinemaAD());

        }


        private void btnListMovies_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListMovie());
        }

        private void btnListTicket_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListTicket());
        }

        private void btnListUser_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListUser());
        }

        private void btnListSeat_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcListSeat());
        }

        private void btnListTimeShowing_Click(object sender, EventArgs e)
        {
            clearpanel();
            pnlBackground.Controls.Add(new UcTimeShow());
        }

        private void btnNewVoucher_Click(object sender, EventArgs e)
        {
            
        }
    }
}
