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

        private void btnTimeShowing_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            TestApp new_Voucher = new TestApp();
            new_Voucher.Show();
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
            pnlBackground.Controls.Add(new UcListTicketAD());
        }
    }
}
