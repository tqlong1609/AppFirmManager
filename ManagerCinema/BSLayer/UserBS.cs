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

        public string get_ID_User(string Username)
        {
            string sqlString = "SELECT idUser FROM Account JOIN Customer ON Account.idAccount = Customer.idUser WHERE Username = '" + Username + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
