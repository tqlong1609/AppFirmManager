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
    public partial class FmAddRoom : FormMain
    {
        private RoomCinemaBS roomCinemaBS;
        private CinemaBS cinemaBS;
        private DataTable dataCinema;

        public FmAddRoom()
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

        private void FmAddRoom_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownForm(e, this);
        }

        private void FmAddRoom_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveForm(e, this);
        }

        private void FmAddRoom_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpForm(this);
        }

        private void FmAddRoom_Load(object sender, EventArgs e)
        {
            cinemaBS = new CinemaBS();
            roomCinemaBS = new RoomCinemaBS();
            dataCinema = cinemaBS.loadData();

            foreach(DataRow rows in dataCinema.Rows)
            {
                cbxCinema.AddItem(rows["Name"].ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text != "" && cbxCinema.selectedIndex != -1)
            {
                if (roomCinemaBS.insertRoom(CommonFunction.getIdOnTime(),
                dataCinema.Rows[cbxCinema.selectedIndex][0].ToString(), txtName.Text))
                {
                    MessageBox.Show("Add success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UcListSeat.isResetRoom = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Add fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
