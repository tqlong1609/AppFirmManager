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
        }
    }
}
