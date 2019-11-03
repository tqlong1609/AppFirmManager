using ManagerCinema.ObjectFolder;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class FmDetailMovie : FormMain
    {
        private Thread threadForm;

        private Movie movie;

        public FmDetailMovie(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
        }

        private void FmDetailMovie_Load(object sender, EventArgs e)
        {
            loadItemsFromMovie();
            loadItemsFromCinema();
        }

        private void loadItemsFromCinema()
        {

        }

        private void loadItemsFromMovie()
        {
            pbxMovie.Image = movie.getImage();
            lbNameMovie.Text = movie.getNameMovie();
            lbTime.Text = movie.getTime().ToString();
            lbDirector.Text = movie.getDirector();
            lbCountry.Text = movie.getCountry();
            lbProducer.Text = movie.getProducer();
            lbType.Text = movie.getTypeFirm();
            lbActor.Text = movie.getActor();
            lbDate.Text = movie.getDate();
            lbStatus.Text = movie.getStatus().ToString();
            lbContent.Text = movie.getContent();
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
        private void FmDetailMovie_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmDetailMovie_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmDetailMovie_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            if (TypeLogin.typeLogin == ETypeLogin.user)
            {
                this.Close();
                threadForm = new Thread(openFormTicket);
                threadForm.SetApartmentState(ApartmentState.STA);
                threadForm.Start();
            }
            else
            {
                MessageBox.Show("You have to login to buy ticket", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void openFormTicket()
        {
            Application.Run(new FmTicket(movie));
        }
    }
}
