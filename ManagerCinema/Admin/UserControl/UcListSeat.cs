using System;
using System.Data;
using System.Windows.Forms;
using ManagerCinema.BSLayer;

namespace ManagerCinema
{
    public partial class UcListSeat : UserControl
    {
        public static bool isResetRoom = false;
        private SeatBS SeatBS;
        private RoomCinemaBS roomCinemaBS;
        private DataTable dataRoom;
        public static bool isReset = false;
        private int indexRow;

        public UcListSeat()
        {
            InitializeComponent();
        }

        private void UcListSeat_Load(object sender, EventArgs e)
        {
            SeatBS = new SeatBS();
            roomCinemaBS = new RoomCinemaBS();

            //gvwSeat.DataSource = SeatBS.loadData();
            loadRoom();
            
        }

        private void loadRoom()
        {
            
            dataRoom = roomCinemaBS.loadData();
            foreach(DataRow rows in dataRoom.Rows)
            {
                cbxRoom.AddItem(rows["Name"].ToString());
            }
        }

        private void cbxRoom_onItemSelected(object sender, EventArgs e)
        {
            loadSeatFollowingIdRoom(dataRoom.Rows[cbxRoom.selectedIndex][0].ToString());
        }

        private void loadSeatFollowingIdRoom(string v)
        {
            gvwSeat.DataSource = SeatBS.loadSeatFollowingIdRoom(v);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            new FmAddRoom().ShowDialog();
            if(isResetRoom)
            {
                cbxRoom.Clear();
                loadRoom();
                isResetRoom = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddSeat().ShowDialog();
            if(isReset)
            {
                if(cbxRoom.selectedIndex == -1)
                {
                    return;
                }
                loadSeatFollowingIdRoom(dataRoom.Rows[cbxRoom.selectedIndex][0].ToString());
                isReset = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(gvwSeat.Rows.Count > 0 && indexRow >= 0)
            {
                if (MessageBox.Show("Are you sure delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    string idRoom = gvwSeat.Rows[indexRow].Cells[0].Value.ToString();
                    string idCinema = gvwSeat.Rows[indexRow].Cells[1].Value.ToString();
                    string name = gvwSeat.Rows[indexRow].Cells[2].Value.ToString();
                    if (SeatBS.deleteSeat(idRoom, idCinema, name))
                    {
                        MessageBox.Show("Delete success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadSeatFollowingIdRoom(dataRoom.Rows[cbxRoom.selectedIndex][0].ToString());
                        indexRow = 0;
                    }
                    else
                    {
                        MessageBox.Show("Delete fail", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void gvwSeat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }
    }
}
