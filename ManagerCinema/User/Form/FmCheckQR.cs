using ManagerCinema.ObjectFolder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace ManagerCinema
{
    public partial class FmCheckQR : FormMain
    {
        private Thread threadForm;
        private Movie movie;
        private User user;
        private int idRoomCinema;

        // id ticket used to get qr code
        private int idTicket;

        public FmCheckQR(Movie movie, User user, int idRoomCinema, int idTicket)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
            this.idRoomCinema = idRoomCinema;
            this.idTicket = idTicket;
        }

        // Need to add an input here
        private void FmCheckQR_Load(object sender, EventArgs e)
        {
            var barcodeWriter = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new EncodingOptions
                {
                    Height = 150,
                    Width = 150,
                    Margin = 0
                }
            };

            using (var bitmap = barcodeWriter.Write(idTicket.ToString()))
            {
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    var image = Image.FromStream(stream);
                    pictureBox1.Image = image;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmCheckQR_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmCheckQR_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmCheckQR_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            threadForm = new Thread(openFormReview);
            threadForm.SetApartmentState(ApartmentState.STA);
            threadForm.Start();
        }

        private void openFormReview()
        {
            Application.Run(new FmReview(movie, user,idRoomCinema));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 3;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ImageFormat savetype = ImageFormat.Jpeg;
                switch (sfd.FilterIndex)
                {
                    case 1: savetype = ImageFormat.Bmp; break;
                    case 2: savetype = ImageFormat.Gif; break;
                    case 3: savetype = ImageFormat.Jpeg; break;
                    case 4: savetype = ImageFormat.Png; break;
                    case 5: savetype = ImageFormat.Tiff; break;
                    default: break;
                }
                pictureBox1.Image.Save(sfd.FileName, savetype);
            }
        }
    }
}
