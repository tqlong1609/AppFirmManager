using ManagerCinema.DBLayer;
using System.Data;


namespace ManagerCinema.BSLayer
{
    public class LoginBS
    {
        DBMain dBMain;
        public LoginBS()
        {
            dBMain = new DBMain();
        }

        public LoginBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public string Login(string Username, string Password)
        {
            string sqlstring = "select count (*) as cnt from sys.server_principals where name = '" + Username + "'";
            string Result = dBMain.ExecuteScalar(sqlstring, CommandType.Text).ToString();

            if (Result == "1")
            {
                string sqlString = "SELECT [dbo].[Login]('" + Username + "','" + Password + "')";
                return dBMain.ExecuteScalar(sqlString, CommandType.Text);
            }
            return "";
        }

        public string Get_Id_User(string Username)
        {
            string sqlString = "select idAccount from Account Where Username = '" + Username + "'";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

    }
}
