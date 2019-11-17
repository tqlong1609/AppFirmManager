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

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllTime()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable Search_Time_Id(string id)
        {
            string sqlString = "select * from TimeShowing_VIEW_Employee where idTimeShowing = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
