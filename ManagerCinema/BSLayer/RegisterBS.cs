using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class RegisterBS
    {
        private DBMain dBMain;

        public RegisterBS()
        {
            dBMain = new DBMain();
        }

        public string Regist(string Username, string Password)
        {
            string sqlString = "SELECT [dbo].[Login]('" + Username + "','" + Password + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
