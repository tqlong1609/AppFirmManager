using ManagerCinema.BSLayer;
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
    public partial class AddSeat : Form
    {
        private SeatBS seatBS;
        private RoomCinemaBS roomCinemaBS;

        private DataTable dataRoom;

        public AddSeat()
        {
            InitializeComponent();
        }

        private void AddSeat_Load(object sender, EventArgs e)
        {
            List<string> listCinem = new List<string>();
            roomCinemaBS = new RoomCinemaBS();
            seatBS = new SeatBS();

            dataRoom = roomCinemaBS.loadCinemaAndRoom();

            foreach (DataRow rows in dataRoom.Rows)
            {
                listCinem.Add(rows["nameCinema"].ToString());
            }

            listCinem = listCinem.Distinct().ToList();

            foreach (string temp in listCinem)
            {
                cbxCinema.AddItem(temp);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cbxCinema.selectedIndex != -1 && cbxRoom.selectedIndex != -1 && txtName.Text != "")
            {
                // check format A1...
                if (checkFormat())
                {
                    string idCinema = "";
                    string idRoom = "";

                    foreach (DataRow rows in dataRoom.Rows)
                    {
                        if (rows["nameCinema"].ToString() == cbxCinema.selectedValue
                            && rows["nameRoom"].ToString() == cbxRoom.selectedValue)
                        {
                            idCinema = rows["idCinema"].ToString();
                            idRoom = rows["idRoomCinema"].ToString();
                        }
                    }
                    if (!checkExist(idRoom,
                        idCinema, txtName.Text))
                    {

                        if (seatBS.insertSeat(idRoom,
                            idCinema,
                            txtName.Text))
                        {
                            MessageBox.Show("Add success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UcListSeat.isReset = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Add fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Exist name !!!\nPlease enter name again", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtName.Text = "";
                        txtName.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Name Seat not is true format\nFormat: A1,A2,...Z8");
                    txtName.Text = "";
                    txtName.Focus();
                }
            }
        }

        private bool checkExist(string idRoom,string idCinema, string name)
        {
            return seatBS.checkExistNameSeat(idRoom, idCinema, name);
        }

        private bool checkFormat()
        {
            if (txtName.Text.Length != 2)
                return false;
            if (txtName.Text[0] < 'A' || txtName.Text[0] > 'Z')
                return false;
            if (txtName.Text[1] < '1' || txtName.Text[1] > '8')
                return false;
            return true;
        }

        private void cbxCinema_onItemSelected(object sender, EventArgs e)
        {
            cbxRoom.Clear();
            foreach (DataRow rows in dataRoom.Rows)
            {
                if (rows["nameCinema"].ToString().Equals(cbxCinema.selectedValue))
                {
                    cbxRoom.AddItem(rows["nameRoom"].ToString());
                }
            }
        }
    }
}
