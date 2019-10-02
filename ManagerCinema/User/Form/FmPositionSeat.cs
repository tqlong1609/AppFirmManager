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
    public partial class FmPositionSeat : FormMain
    {
        private List<SeatNomal> arrRowSeatNomal;
        private List<SeatBench> arrRowSeatBench;

        private Thread threadForm;
        private Movie movie;
        private User user;
        private SeatBench seatBench;
        private SeatNomal seatNomal;
        private int countNomal;
        private int countBench;

        public FmPositionSeat(Movie movie,User user)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Form Move
        private void FmPositionSeat_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmPositionSeat_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmPositionSeat_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        private void FmPositionSeat_Load(object sender, EventArgs e)
        {
            // NOTE: test tạm thời
            // colums seat nomal
            List<Seat> seatsNomal = new List<Seat>();
            seatsNomal.Add(new Seat("1"));
            seatsNomal.Add(new Seat("2"));
            seatsNomal.Add(new Seat("3"));
            seatsNomal.Add(new Seat("4"));
            seatsNomal.Add(new Seat("5"));
            seatsNomal.Add(new Seat("6"));
            seatsNomal.Add(new Seat("7"));
            seatsNomal.Add(new Seat("8"));
            seatsNomal.Add(new Seat("9"));
            
            // columns seat bench
            List<Seat> seatsBench = new List<Seat>();
            seatsBench.Add(new Seat("1"));
            seatsBench.Add(new Seat("2"));
            seatsBench.Add(new Seat("3"));
            seatsBench.Add(new Seat("4"));
            seatsBench.Add(new Seat("5"));

            arrRowSeatNomal = new List<SeatNomal>();
            arrRowSeatBench = new List<SeatBench>();

            for (int i = 0; i < 9; i++) // row = 9
            {
                arrRowSeatNomal.Add(new SeatNomal("A", seatsNomal));
            }
            arrRowSeatBench = new List<SeatBench>();
            for (int i = 0; i < 3; i++) // row = 3
            {
                arrRowSeatBench.Add(new SeatBench("A", seatsBench));
            }

            loadListSeatNomal();
            loadListSeatBench();
            
            countNomal = user.CountTicketNomal;
            countBench = user.CountTicketBench;
            lbCountNomal.Text = countNomal.ToString();
            lbCountBench.Text = countBench.ToString();

            loadValuePanelSeat();
            //loadValueDropDown();
        }

        private void loadListSeatBench()
        {

        }

        private void loadListSeatNomal()
        {

        }

        private void loadValuePanelSeat()
        {
            foreach(SeatNomal temp in arrRowSeatNomal)
            {
                pnlSeat.Controls.Add(new ucSeatNomal(temp));
            }
            foreach (SeatBench temp in arrRowSeatBench)
            {
                pnlSeat.Controls.Add(new ucSeatBench(temp));
            }
        }

        private void loadValueDropDown()
        {
            if (countNomal > 0)
            {
                drdRow.AddItem("A");
                drdRow.AddItem("B");
                drdRow.AddItem("C");
                drdRow.AddItem("D");
                drdRow.AddItem("E");
                drdRow.AddItem("F");
                drdRow.AddItem("G");
                drdRow.AddItem("H");
            }
            if (countBench > 0)
            {
                drdRow.AddItem("I");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormTicket);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormTicket()
        {
            Application.Run(new FmTicket(movie));
        }
    }
}
