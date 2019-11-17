using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

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
            string idTicket = CommonFunction.getIdOnTime().ToString();
            string username = txtUsername.Text;
            string room = room_drop.Text;
            string city = city_drop.selectedValue; 
            string cinema = cinema_drop.Text;
            string movie = movie_drop.Text;
            string time_show = timeshow_drop.selectedValue; ;
            string date = date_drop.selectedValue;
            string time = time_drop.selectedValue;
            string money = money_drop.Text;
            string seat = seat_drop.selectedValue;

            TicketBS ticketBS = new TicketBS();

            UserBS userBS = new UserBS();
            string idUser = userBS.get_ID_User(username);

            ticketBS.insert_Ticket(idTicket, idUser, cinema, room, seat, time, date, movie, money);
        }
    }
}
