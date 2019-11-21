using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class UserBS
    {
        private DBMain dBMain;
        private string idUser;

        public UserBS()
        {
            dBMain = new DBMain();
        }

        public UserBS(string id)
        {
            dBMain = new DBMain();
            idUser = id;
        }

        public UserBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllCustomer()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public string get_ID_User(string Username)
        {
            string sqlString = "SELECT idUser FROM Account JOIN Customer ON Account.idAccount = " +
                "Customer.idUser WHERE Username = '" + Username + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string get_Username(string id)
        {
            string sqlString = "SELECT Username FROM Account WHERE idAccount = '" + id + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string get_Email(string id)
        {
            string sqlString = "SELECT Email FROM Customer WHERE idUser = '" + id + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string get_Date(string id)
        {
            string sqlString = "SELECT DateOfBirth FROM Customer WHERE idUser = '" + id + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string get_Address(string id)
        {
            string sqlString = "SELECT Address FROM Customer WHERE idUser = '" + id + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public string get_Phone(string id)
        {
            string sqlString = "SELECT Phone FROM Customer WHERE idUser = '" + id + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
