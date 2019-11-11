using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    public class LoginBS
    {
        private DBMain dBMain;

        public LoginBS()
        {
            dBMain = new DBMain();
        }

        public string Login(string Username, string Password)
        {
            string sqlString = "SELECT [dbo].[Login]('" + Username + "','" + Password + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
