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
            string sqlString = string.Format("select * from Seat where name = '{0}'",id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable loadSeatFollowingIdRoom(string id)
        {
            string sqlString = string.Format("exec getSeatFollowingIdRoom @id = {0}",id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool insertSeat(string idRoomCinema, string idCinema, string name)
        {
            string sqlString = string.Format("insert into Seat values({0},{1},'{2}','{3}')",
                idRoomCinema,idCinema,name,"True");
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool checkExistNameSeat(string idRoom, string idCinema, string name)
        {
            string sqlString = string.Format("select * from checkExistNameSeat({0},{1},'{2}')",
                idRoom,idCinema,name);
            DataTable data = dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
            if(int.Parse( data.Rows[0][0].ToString().Trim()) > 0)
            {
                return true;
            }
            return false;
        }

        public bool deleteSeat(string idRoom, string idCinema, string name)
        {
            string sqlString = string.Format("exec deleteSeat @idRoom = {0}," +
                " @idCinema = {1}, @name = '{2}'", idRoom, idCinema, name);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
