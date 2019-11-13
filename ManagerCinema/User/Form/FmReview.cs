using ManagerCinema.BSLayer;
using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmReview : FormMain
    {
        private Thread threadForm;
        private Movie movie;
        private User user;
        private int idRoomCinema;
        private TicketBS ticketBS;

        private int idTicket;

        public FmReview(Movie movie, User user, int idRoomCinema)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
            this.idRoomCinema = idRoomCinema;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmReview_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmReview_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmReview_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormPositionSeat);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormPositionSeat()
        {
            Application.Run(new FmPositionSeat(movie, user, idRoomCinema));
        }

        private void FmReview_Load(object sender, EventArgs e)
        {
            ticketBS = new TicketBS();

            loadValueBegin();
            
        }

        private void loadValueBegin()
        {
            lbNameMovie.Text = movie.getNameMovie();
            pbxMovie.Image = movie.getImage();
            lbAddress.Text = UcLogin.ticket.Address;
            lbCinema.Text = UcLogin.ticket.NameCinema;
            lbShowtime.Text = UcLogin.ticket.Date + " " + UcLogin.ticket.Time;
            lbNameSeat.Text = UcLogin.ticket.NameSeat;
            lbSumMonney.Text = CommonFunction.formatMonney(UcLogin.ticket.Price);
            lbNameRoom.Text = UcLogin.ticket.NameRoom;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (saveTicket())
            {
                this.Close();
                threadForm = new Thread(openFormCheckQR);
                threadForm.SetApartmentState(ApartmentState.STA);
                threadForm.Start();
            }
        }

        private void openFormCheckQR()
        {
            Application.Run(new FmCheckQR(movie, user, idRoomCinema,idTicket));
        }

        // insert into ticket get idTicket
        private bool saveTicket()
        {
            idTicket = CommonFunction.getIdOnTime();
            if(
            ticketBS.insertTicket(idTicket, UcLogin.ticket.IdUser, UcLogin.ticket.IdCinema,
                UcLogin.ticket.IdRoomCinema, UcLogin.ticket.NameSeat, UcLogin.ticket.Time,
                UcLogin.ticket.Date, UcLogin.ticket.IdMovie, UcLogin.ticket.Price))
            {
                return true;
            }
            return false;
        }
    }
}
