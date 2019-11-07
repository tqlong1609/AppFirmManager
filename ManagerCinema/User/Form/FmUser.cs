using ManagerCinema.BSLayer;
using ManagerCinema.ObjectFolder;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ManagerCinema
{
    public partial class Form1 : FormMain
    {
        private Thread threadForm;
        private List<Movie> listMovies;
        private MovieBS movieBS;

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
            listMovies = new List<Movie>();
            movieBS = new MovieBS();

            loadMovies();
            // add Usercontrol permisstion login into panel
            addItemGuestTheme();
        }

        private void loadMovies()
        {
            DataTable dataMovies = movieBS.loadData();
            foreach(DataRow rows in dataMovies.Rows)
            {
                Image img = CommonFunction.stringToImg(rows["image"].ToString().Trim());
                listMovies.Add(new Movie(int.Parse(rows["IdMovie"].ToString()),img, rows["Name"].ToString(), int.Parse(rows["Time"].ToString()),
                    rows["Director"].ToString(), rows["Producer"].ToString(), rows["Type"].ToString()
                    , rows["Actor"].ToString(), rows["Date"].ToString(), rows["Content"].ToString(),
                    rows["Country"].ToString(), int.Parse(rows["Price"].ToString())));
            }
        }

        private void addItemGuestTheme()
        {
            flpBackground.Controls.Add(new UcBackground());

            foreach(Movie movie in listMovies)
            {
                flpBackground.Controls.Add(new UcItemMovie(movie));
            }
        }

        #region Form Move
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
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

        private void lbBuyTicket_Click(object sender, EventArgs e)
        {
            if (TypeLogin.typeLogin == ETypeLogin.user)
            {
                // todo: 
            }
            else
            {
                MessageBox.Show("You have to login to buy ticket", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbxProfile_Click(object sender, EventArgs e)
        {
            new FmProfile().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure log out ?", "Question",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                threadForm = new Thread(openFormLogin);
                threadForm.SetApartmentState(ApartmentState.STA);
                threadForm.Start();
            }
        }

        private void openFormLogin()
        {
            Application.Run(new FmLogin());
        }
    }
}
