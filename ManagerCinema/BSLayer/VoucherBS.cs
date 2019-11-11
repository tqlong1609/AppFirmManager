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

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllVoucher()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
