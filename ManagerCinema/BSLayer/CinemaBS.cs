using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class CinemaBS
    {
        private DBMain dBMain;
        public CinemaBS()
        {
            dBMain = new DBMain();
        }

        public CinemaBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllCinema()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public string isExisted(string id)
        {
            string sqlString = "select dbo.Check_Cinema(" + id + ")";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public bool insertCinema(int idCinema, string name, string address, string timeOpen, string timeClose)
        {
            string sqlString = string.Format("exec insertCinema @idCinema = {0}, " +
                "@name = N'{1}',@address = N'{2}',@timeOpen='{3}',@timeClose='{4}'",
                idCinema, name, address, timeOpen, timeClose);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);

        }

        public bool updateCinema(string idCinema, string name, string address, string timeOpen, string timeClose)
        {
            string sqlString = string.Format("exec updateCinema @idCinema = {0}," +
                " @name = N'{1}',@address = N'{2}'," +
                "@timeOpen='{3}',@timeClose='{4}'",idCinema,name,address,timeOpen,timeClose);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);

        }

        public bool Delete_Cinema(string id)
        {
            string sqlString = "Delete From Cinema Where idCinema=" + id;
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public DataTable Search_Voucher_Id(string id)
        {
            string sqlString = "select * from Cinema where idCinema = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
