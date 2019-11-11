using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class UserBS
    {
        private DBMain dBMain;

        public UserBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllCustomer()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
