using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagerCinema.ObjectFolder;
using System.Runtime.InteropServices;
using System;

namespace ManagerCinema
{
    public partial class UcDetailMovie : UserControl
    {
        private Movie movie;

        [DllImport("user32.dll", EntryPoint = "ShowCaret")]
        public static extern long ShowCaret(IntPtr hwnd);
        [DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);

        public UcDetailMovie(Movie movie)
        {
            InitializeComponent();
            
            this.movie = movie;
            HideCaret(txtContent.Handle);
        }

        private void UcDetailMovie_Load(object sender, System.EventArgs e)
        {
            pbxMovie.Image      = movie.getImage();
            lbNameMovie.Text    = movie.getNameMovie();
            lbTime.Text         = movie.getTime().ToString();
            lbDirector.Text     = movie.getDirector();
            lbCountry.Text      = movie.getCountry();
            lbProducer.Text     = movie.getProducer();
            lbType.Text         = movie.getTypeFirm();
            lbActor.Text        = movie.getActor();
            lbDate.Text         = movie.getDate();
            lbStatus.Text       = movie.getStatus().ToString();
            txtContent.Text     = movie.getContent();
        }
    }
}
