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
        private TimeBS timeBS;
        private MovieBS movieBS;
        private CinemaBS cinemaBS;
        private RoomCinemaBS roomCinemaBS;

        DataTable dataMovie;
        DataTable dataCinema;
        DataTable dataRoomCinema;

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
            initProject();

             dataMovie = movieBS.loadData();
             dataCinema = cinemaBS.loadData();
             dataRoomCinema = roomCinemaBS.loadData();

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

        private void initProject()
        {
            movieBS = new MovieBS();
            cinemaBS = new CinemaBS();
            roomCinemaBS = new RoomCinemaBS();
            timeBS = new TimeBS();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = CommonFunction.getIdOnTime();
            int indexMovie = cbxMovie.selectedIndex;
            int indexCinema = cbxCinema.selectedIndex;
            int indexRoomCinema = cbxRoomCinema.selectedIndex;
            string valuedate = dpkDateShowing.Value.ToLongDateString();

            if (indexMovie >= 0 &&
                indexCinema >= 0 &&
                indexRoomCinema >= 0
                )
            {
                if (timeBS.insertTimeShowing(id,dataMovie.Rows[indexMovie][0].ToString(),
                    dataRoomCinema.Rows[indexRoomCinema][0].ToString(),
                    dpkTime.Value.ToShortTimeString(),dpkDateShowing.Value.ToLongDateString(),
                    dataCinema.Rows[indexCinema][0].ToString()
                    ))
                {
                    MessageBox.Show("Success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter full values", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
