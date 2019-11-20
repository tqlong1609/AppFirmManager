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
                loadRoom();
                isResetRoom = false;
            }
        }
    }
}
