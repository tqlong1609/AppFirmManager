using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmTicket : FormMain
    {
        private const int PRICE_NOMAL = 50000;
        private const int PRICE_BENCH = 100000;
        private const string FORMAT_MONNEY = "{0:#,##0}"; // format: 20,000

        private Thread threadForm;
        private Movie movie;
        private int priceNomal;
        private int priceBench;

        public FmTicket(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            priceNomal = PRICE_NOMAL;
            priceBench = PRICE_BENCH;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormDetailMovie);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormDetailMovie()
        {
            Application.Run(new FmDetailMovie(movie) );
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormPositionSeat);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormPositionSeat()
        {
            Application.Run(new FmPositionSeat(movie));
        }

        private void nudNomal_ValueChanged(object sender, EventArgs e)
        {
            priceNomal = (int)nudNomal.Value * PRICE_NOMAL;
            lbSumNomal.Text = 
                string.Format(FORMAT_MONNEY, priceNomal);
            lbSum.Text = string.Format(FORMAT_MONNEY, priceNomal + priceBench);
        }

        private void nudBench_ValueChanged(object sender, EventArgs e)
        {
            priceBench = (int)nudBench.Value * PRICE_BENCH;
            lbSumBench.Text =
                string.Format(FORMAT_MONNEY, priceBench);
            lbSum.Text = string.Format(FORMAT_MONNEY, priceNomal + priceBench);
        }

        #region Form Move
        private void FmTicket_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmTicket_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmTicket_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

    }
}
