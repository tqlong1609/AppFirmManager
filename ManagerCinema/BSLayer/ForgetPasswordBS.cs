using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class ForgetPasswordBS
    {
        private DBMain dBMain;

        public ForgetPasswordBS()
        {
            dBMain = new DBMain();
        }

        public string Send_Mail_To(string Username)
        {
            string sqlString = "SELECT [dbo].[take_Gmail]('" + Username + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
        public bool Change_Password(string Gmail, string New_Password)
        {
            string sqlString = "Update Account Set Password=N'" + New_Password +
                "' Where Email='" + Gmail + "'";
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
