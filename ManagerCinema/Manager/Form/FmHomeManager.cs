using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;
using BarcodeReaderApp;
using System.Threading;

namespace ManagerCinema
{
    public partial class FmHomeManager : FormMain
    {
        private Thread thread;

        public FmHomeManager()
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

        private void FmHomeManager_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmHomeManager_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmHomeManager_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void openFormLogin()
        {
            Application.Run(new FmLogin());
        }

        private void btnListTicket_Click(object sender, EventArgs e)
        {
            clearPanel();
            pnlBackground.Controls.Add(new UcListBackground());
        }

        private void clearPanel()
        {
            pnlBackground.Controls.Clear();
        }

        private void btnTimeShowing_Click(object sender, EventArgs e)
        {
            clearPanel();
            pnlBackground.Controls.Add(new UcTimeShowing());
        }

        private void btnListSeat_Click(object sender, EventArgs e)
        {
            clearPanel();
            pnlBackground.Controls.Add(new UcSeat());
        }

        private void FmHomeManager_Load(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //thread = new Thread(openFmQr);
            //thread.SetApartmentState(ApartmentState.STA);
            //thread.Start();
            BarcodeReaderApp.Form1 Scan_Ticket = new BarcodeReaderApp.Form1();
            Scan_Ticket.Show();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            new FmBookticket().ShowDialog();
        }

        private void openFmQr()
        {
            BarcodeReaderApp.Form1 Scan_Ticket = new BarcodeReaderApp.Form1();
            Scan_Ticket.Show();
        }
    }
}
