using ManagerCinema.ObjectFolder;
using System;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class FmProfile : FormMain
    {
        private string idUser;
        public FmProfile()
        {
            InitializeComponent();
        }
        public FmProfile(string id)
        {
            InitializeComponent();
            idUser = id;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmProfile_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FmEditUser().ShowDialog();
        }

        private void FmProfile_Load(object sender, EventArgs e)
        {
            UserBS userBS = new UserBS(idUser);
            lbNameMovie.Text = userBS.get_Username(idUser);
            label5.Text = userBS.get_Email(idUser);
            label3.Text = userBS.get_Date(idUser);
            label7.Text = userBS.get_Address(idUser);
            label9.Text = userBS.get_Phone(idUser);
        }
    }
}
