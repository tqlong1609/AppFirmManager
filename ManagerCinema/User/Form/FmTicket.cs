using ManagerCinema.BSLayer;
using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmTicket : FormMain
    {

        private Thread threadForm;
        private Movie movie;
        private User user;
        private MovieBS movieBS;
        private int priceNomal = 50000;
        private int priceBench = 100000;
        private DataTable inforTicket;
        private List<String> listAddress;
        private int idCinema;



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
            setTicket();
            this.Close();
            threadForm = new Thread(openFormPositionSeat);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void setTicket()
        {
            UcLogin.ticket.IdCinema = idCinema;
            UcLogin.ticket.Date = cbxDate.selectedValue;
            UcLogin.ticket.Time = cbxTime.selectedValue;
        }

        private void openFormPositionSeat()
        {
            Application.Run(new FmPositionSeat(movie, user, idCinema));
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
            movieBS = new MovieBS();
            listAddress = new List<string>();

            user = new User();

            initNomal();

            loadInfoTicket();

        }

        private void loadInfoTicket()
        {
             inforTicket = movieBS.getInforTicketFromIdMovies(movie.getId());

            foreach(DataRow dataRow in inforTicket.Rows)
            {
                listAddress.Add(dataRow["Address"].ToString());
            }

            listAddress = listAddress.Distinct().ToList();

            foreach(string value in listAddress)
            {
                cbxCity.AddItem(value);
            }

            priceNomal = movie.getPrice();
            priceBench = movie.getPrice() * 2;
        }

        private void initNomal()
        {
            user.CountTicketNomal = 1;
            user.CountTicketBench = 0;

           
        }

        private void initBench()
        {
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
        

        private void cbxCity_onItemSelected(object sender, EventArgs e)
        {
            cbxCinema.Clear();
            cbxDate.Clear();
            cbxTime.Clear();
            foreach(DataRow rows in inforTicket.Rows)
            {
                if (rows["Address"].ToString().Trim().Equals(cbxCity.selectedValue))
                {
                    cbxCinema.AddItem(rows["Name"].ToString());
                }   
            }
        }

        private void cbxDate_onItemSelected(object sender, EventArgs e)
        {
            cbxTime.Clear();
            foreach (DataRow rows in inforTicket.Rows)
            {
                if (rows["Name"].ToString().Trim().Equals(cbxCinema.selectedValue)
                    && rows["Date"].ToString().Trim().Equals(cbxDate.selectedValue))
                {
                    cbxTime.AddItem(rows["Time"].ToString());
                }
            }
        }

        private void cbxCinema_onItemSelected(object sender, EventArgs e)
        {
            cbxDate.Clear();
            cbxTime.Clear();
            foreach (DataRow rows in inforTicket.Rows)
            {
                if (rows["Name"].ToString().Trim().Equals(cbxCinema.selectedValue))
                {
                    cbxDate.AddItem(rows["Date"].ToString());
                    idCinema = int.Parse(rows["idCinema"].ToString());
                }
            }
        }
    }
}
