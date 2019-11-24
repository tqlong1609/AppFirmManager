using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    public class RoomCinemaBS
    {
        private DBMain dBMain;

        public RoomCinemaBS()
        {
            dBMain = new DBMain();
        }

        public RoomCinemaBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllRoomCinema()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable loadCinemaAndRoom()
        {
            string sqlString = "select * from getNameCinemaAndRoom()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool insertRoom(int id, string idCinema, string name)
        {
            string sqlString = string.Format("exec addRoomCinema @idRoom = {0}, @idCinema = {1}, " +
                "@name = N'{2}', @capacity = 0",id,idCinema,name);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
