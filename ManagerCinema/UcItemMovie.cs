using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCinema.ObjectFolder;

namespace ManagerCinema
{
    public partial class UcItemMovie : UserControl
    {
        private Movie movie;

        public UcItemMovie(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
        }

        private void UcItemMovie_Load(object sender, EventArgs e)
        {
            pbxMovie.Image = movie.getImage();
            lbNameMovie.Text = movie.getNameMovie();
            btnBuyTicket.Visible = false;
            moveTextBetweenImage();
            
        }

        private void moveTextBetweenImage()
        {
            lbNameMovie.Location = new Point(this.Location.X + (pbxMovie.Size.Width / 2) -
                lbNameMovie.Width / 2, this.Location.Y + pbxMovie.Size.Height + 5);
        }

        private void pbxMovie_MouseMove(object sender, MouseEventArgs e)
        {
            btnBuyTicket.Visible = true;
            //37, 37, 34
            pbxMovie.BackColor = Color.FromArgb(30,30,30);
        }

        private void pbxMovie_MouseLeave(object sender, EventArgs e)
        {
            btnBuyTicket.Visible = false;
            pbxMovie.BackColor = Color.FromArgb(37, 37, 34);
        }
    }
}
