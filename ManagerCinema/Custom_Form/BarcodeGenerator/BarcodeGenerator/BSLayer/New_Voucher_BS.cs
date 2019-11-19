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

        public bool Add_New_Voucher(int IdVoucher, string Name, int Value, bool Status)
        {
            string sqlString = string.Format("exec insertVoucher @id = {0}, @name = N'{1}', @value = {2}, @status = '{3}'", 
                IdVoucher, Name, Value, Status);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
