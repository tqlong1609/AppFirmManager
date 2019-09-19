using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.ObjectFolder
{
    public class Movie
    {
        private Image image;
        private string nameMovie;

        public Movie(Image image, string nameMovie)
        {
            this.image = image;
            this.nameMovie = nameMovie;
        }

        public Image getImage() {
            return image;
        }

        public string getNameMovie() {
            return nameMovie;
        }
    }
}
