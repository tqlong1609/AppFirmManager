using ManagerCinema.DBLayer;
using System.Data;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace ManagerCinema.BSLayer
{
    public class LoginBS
    {
        DBMain dBMain;
        public LoginBS()
        {
            dBMain = new DBMain();
        }

        public string Login(string Username, string Password)
        {
            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=.;Initial Catalog=DBSM1;database=login;integrated security=SSPI";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from . where username=@usr and password=@pwd", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", Username);
            scmd.Parameters.AddWithValue("@pwd", Password);
            try
            {
                scn.Open();
            }
            catch
            {
                return "";
            }

            if (scmd.ExecuteScalar().ToString() == "1")
            {
                scn.Close();
                string sqlString = "SELECT [dbo].[Login]('" + Username + "','" + Password + "')";
                return dBMain.ExecuteScalar(sqlString, CommandType.Text);
            }
            scn.Close();
            return "";
        }
    }
}
