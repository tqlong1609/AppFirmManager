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
    public partial class Form1 : FormMain
    {

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
            // add Usercontrol permisstion login into panel
            pnlChangePermisstion.Controls.Add(new UcPermistionLogin(pnlChangePermisstion));
            addItemGuestTheme();
        }

        private void addItemGuestTheme()
        {
            flpBackground.Controls.Add(new UcBackground());

            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image2.jpg"),"CHÚ HỀ MA QUÁI")));
            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image5.jpg"),"ALLADIN VÀ CÂY ĐÈN THẦN")));
            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image6.jpg"),"BoBoBoi")));
            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image7.jpg"),"THE KID WHO WOULD BE KING")));
            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image8.jpg"),"DRAGON THE HINDDEN WORLD")));
            flpBackground.Controls.Add(new UcItemMovie(
                new Movie(Image.FromFile("Image//image9.jpg"),"DORAEMON MẶT TRĂNG PHIÊU LƯU KÝ")));
        }

        #region Form Move
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e,this);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e,this);
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }
        #endregion

        public FlowLayoutPanel getFlowLayoutPanel()
        {
            return flpBackground;
        }
    }
}
