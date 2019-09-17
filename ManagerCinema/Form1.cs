using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class Form1 : Form
    {
        private bool isMoveForm;
        private Point pStart;

        public Form1()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addItemGuestTheme();
            
        }

        private void addItemGuestTheme()
        {
            flpBackground.Controls.Add(new UcBackground());

            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image2.jpg"))));
            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image5.jpg"))));
            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image6.jpg"))));
            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image7.jpg"))));
            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image8.jpg"))));
            flpBackground.Controls.Add(new UcItemMovie(new Movie(Image.FromFile("Image//image9.jpg"))));
        }

        #region Form Move
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            isMoveForm = true;
            pStart = new Point(e.X, e.Y);
            this.Cursor = Cursors.Hand;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMoveForm)
            {
                this.Location = new Point(this.Left + e.X - pStart.X, this.Top + e.Y - pStart.Y);
                this.Cursor = Cursors.Hand;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isMoveForm = false;
            pStart = Point.Empty;
            this.Cursor = Cursors.Default;
        }
        #endregion
    }
}
