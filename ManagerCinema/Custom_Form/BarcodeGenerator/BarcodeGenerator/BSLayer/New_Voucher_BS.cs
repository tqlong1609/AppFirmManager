using System.Data;
using BarcodeLibTest.DBLayer;

namespace BarcodeLibTest.BSLayer
{
    class New_Voucher_BS
    {
        private DBMain dBMain;

        public New_Voucher_BS()
        {
            dBMain = new DBMain();
        }

        public void Add_New_Voucher(int IdVoucher, string Name, int Value, int Status = 1, int IdUser = 1)
        {
            string sqlString = "EXEC New_Voucher '" + IdVoucher + "','" + IdUser + "','" + Name + "','" + Value + "','" + Status + "'";
            dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
