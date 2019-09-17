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

        public Movie(Image image)
        {
            this.image = image;
        }

        public Image getImage() {
            return image;
        }
    }
}
