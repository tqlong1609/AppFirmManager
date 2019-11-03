using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmTicket : FormMain
    {
        private const string FORMAT_MONNEY = "{0:#,##0}"; // format: 20,000

        private Thread threadForm;
        private Movie movie;
        private User user;
        private int priceNomal = 50000;
        private int priceBench = 100000;

        public FmTicket(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
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
            Application.Run(new FmDetailMovie(movie));
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
            Application.Run(new FmPositionSeat(movie, user));
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

        private void FmTicket_Load(object sender, EventArgs e)
        {
            user = new User();

            initNomal();

            lbPriceNomal.Text = formatMonney(priceNomal);
            lbPriceBench.Text = formatMonney(priceBench);
        }

        private void initNomal()
        {
            cbxBench.Checked = false;
            cbxNomal.Checked = true;
            user.CountTicketNomal = 1;
            user.CountTicketBench = 0;
        }

        private void initBench()
        {
            cbxNomal.Checked = false;
            cbxBench.Checked = true;
            user.CountTicketBench = 1;
            user.CountTicketNomal = 0;
        }

        private void cbxNomal_OnChange(object sender, EventArgs e)
        {
            initNomal();
        }

        private void cbxBench_OnChange(object sender, EventArgs e)
        {
            initBench();
        }

        private string formatMonney(int monney)
        {
            return string.Format(FORMAT_MONNEY, monney);
        }
    }
}
