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
    }
}
