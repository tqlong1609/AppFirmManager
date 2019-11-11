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

        public void Regist(string Username, string Numberphone, string Gender, string Email, string Password, string Confirm_Password, string Address, string Date_Of_Birth, string Name)
        {
            string sqlString = "EXEC New_Account '" + Username + "','" + Name + "','" + Numberphone + "','" + Gender + "','" + Email + "','" + Password + "','" + Address + "','" + Date_Of_Birth + "'";
            dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
        public string Check_Username(string Username)
        {
            string sqlString = "SELECT dbo.Check_Username('" + Username + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
