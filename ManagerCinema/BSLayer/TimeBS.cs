using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class TimeBS
    {
        private DBMain dBMain;
        public TimeBS()
        {
            dBMain = new DBMain();
        }

        public bool updateTimeShowing(string id, string idMovie, string idRoom, string time, string date, string idCinema)
        {
            string sqlString = string.Format("exec editTimeShowing @id = {0}, " +
                "@idMovie = {1}, @idRoom = {2}, @time = '{3}', @date = '{4}', @idCinema = {5}",
                id, idMovie, idRoom, time, date, idCinema);

            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);

        }

        public bool removeTimeShowing(string id)
        {
            string sqltring = string.Format("exec removeTimeShowing @id = {0}", id);
            return dBMain.MyExecuteNonQuery(sqltring, CommandType.Text);
        }

        public bool insertTimeShowing(int id, string idMovie, string idRoomCinema, string time , string date, string idCinema)
        {
            string sqlString = string.Format("exec insertTimeShowing @id = {0}, @idMovie = {1}, @idRoomCinema = {2}," +
                " @time = '{3}', @date = '{4}', @idCinema = {5}",id,idMovie,idRoomCinema,time,date,idCinema);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllTime()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable getAllTimeShowing()
        {
            string sqlString = "select * from getInfoTimeShowing()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable Search_Time_Id(string id)
        {
            string sqlString = "select * from TimeShowing_VIEW_Employee where idTimeShowing = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
