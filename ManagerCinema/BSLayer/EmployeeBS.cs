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

        public bool insertEmployee(int id, string name, string email, string dateOfbirth,
            string address, string phone, int salary, int identity, string dateStart,
            string position, bool status, string pathImage)
        {
            string sqlString = string.Format("execute insertEmployee " +
                "@id = {0}," +
                "@name = N'{1}'," +
                "@email = '{2}'," +
                "@dateOfBirth ='{3}'," +
                "@address = '{4}'," +
                "@phone = '{5}'," +
                "@salary = {6}," +
                "@identityCard = {7}," +
                "@dateStart ='{8}'," +
                "@position = '{9}'," +
                "@status = {10}," +
                "@image = '{11}'",
                id,name,email, dateOfbirth,address,phone,salary, identity,dateStart,position,status,email);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
