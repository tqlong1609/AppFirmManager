using ManagerCinema.BSLayer;
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
    public partial class FmAddTimeShowing : FormMain
    {
        private MovieBS movieBS;
        private CinemaBS cinemaBS;
        private RoomCinemaBS roomCinemaBS;

        public FmAddTimeShowing()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FmAddTimeShowing_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAddTimeShowing_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAddTimeShowing_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void FmAddTimeShowing_Load(object sender, EventArgs e)
        {
            movieBS = new MovieBS();
            cinemaBS = new CinemaBS();
            roomCinemaBS = new RoomCinemaBS();

            DataTable dataMovie = movieBS.loadData();
            DataTable dataCinema = cinemaBS.loadData();
            DataTable dataRoomCinema = roomCinemaBS.loadData();

            foreach(DataRow rows in dataMovie.Rows)
            {
                cbxMovie.AddItem(rows["Name"].ToString());
            }

            foreach (DataRow rows in dataCinema.Rows)
            {
                cbxCinema.AddItem(rows["Name"].ToString());
            }

            foreach (DataRow rows in dataRoomCinema.Rows)
            {
                cbxRoomCinema.AddItem(rows["Name"].ToString());
            }

        }
    }
}
