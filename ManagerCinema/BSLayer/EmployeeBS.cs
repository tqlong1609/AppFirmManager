using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class EmployeeBS
    {
        private DBMain dBMain;
        public EmployeeBS()
        {
            dBMain = new DBMain();
        }

        public EmployeeBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllEmployee()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        //public bool removeEmployee(string id)
        //{
        //    string sqlString = 
        //}

        public bool insertEmployee(string username, string password ,string name, string email, string dateOfbirth,
            string address, string phone, int salary, int identity, string dateStart,
            string position, bool status, string pathImage)
        {
            string image = CommonFunction.converImgToString(pathImage);
            string sqlString = string.Format("exec insertEmployee  " +
                "@username = N'{0}',@Password = '{1}'," +
                "@type = '{2}',@name = '{3}'," +
                "@email = '{4}',@dateOfBirth = '{5}'," +
                "@address = N'{6}',@phone = '{7}',@salary = {8}," +
                "@identityCard = {9}, @dateStart = '{10}'," +
                "@position = '{11}',@status = '{12}',@image = '{13}'",
                username,password,"Employee",name,email,dateOfbirth,address,phone,salary,identity,
                dateStart,position,status, image);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool removeEmployee(string id)
        {
            string sqlString = string.Format("exec removeEmployee @idRemove = {0}", id);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
