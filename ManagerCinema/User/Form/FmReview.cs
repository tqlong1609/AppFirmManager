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
    public partial class FmReview : FormMain
    {
        private Thread threadForm;
        private Movie movie;
        private User user;

        public FmReview(Movie movie, User user)
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
            Application.Run(new FmPositionSeat(movie,user));
        }

        private void FmReview_Load(object sender, EventArgs e)
        {
            lbNameMovie.Text = movie.getNameMovie();
            pbxMovie.Image = movie.getImage();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormCheckQR);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormCheckQR()
        {
            Application.Run(new FmCheckQR(movie, user));
        }
    }
}
