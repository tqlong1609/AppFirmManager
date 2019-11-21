using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class SeatBS
    {
        private DBMain dBMain;
        public SeatBS()
        {
            dBMain = new DBMain();
        }

        public SeatBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllSeat()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable Search_Seat_Id(string id)
        {
            string sqlString = "select * from Seat_VIEW_Employee where idRoomCinema = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable loadSeatFollowingIdRoom(string id)
        {
            string sqlString = string.Format("exec getSeatFollowingIdRoom @id = {0}",id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
