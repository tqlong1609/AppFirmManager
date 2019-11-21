using ManagerCinema.DBLayer;
using System.Data;
namespace ManagerCinema.BSLayer
{
    class VoucherBS
    {
        private DBMain dBMain;

        public VoucherBS()
        {
            dBMain = new DBMain();
        }

        public VoucherBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllVoucher()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable Search_Voucher_Id(string id)
        {
            string sqlString = "select idVoucher, Username, Name, Value, " +
                "Voucher_Status from Voucher join Account on Voucher.idUser = Account.idAccount " +
                "WHERE idVoucher = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool Delete_Voucher(string id)
        {
            string sqlString = "Delete From Voucher Where idVoucher=" + id;
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public bool EditVoucher(string id, string name, string value, string status)
        {
            string sqlString = string.Format("exec editVoucher @idVoucher = {0}, " +
                "@name = '{1}', @value = {2}, @status = '{3}'",id,name,value,status);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
