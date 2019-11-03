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

        public FmCheckQR(Movie movie, User user)
        {
            InitializeComponent();
            this.movie = movie;
            this.user = user;
        }

        // Need to add an input here
        private void FmCheckQR_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Định dạng lại Input trong code, đây chỉ là bản Demo");
            // Tạo một chuỗi ở đây và truyền vào barcodeWriter.Write("A") thay cho A
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

            using (var bitmap = barcodeWriter.Write("A"))
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
            Application.Run(new FmReview(movie, user));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
