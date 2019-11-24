using System.Data;
using BarcodeReaderApp.DBLayer;

namespace BarcodeReaderApp.BSLayer
{
    class Scan_Voucher_BS
    {
        private DBMain dBMain;

        public Scan_Voucher_BS()
        {
            dBMain = new DBMain();
        }

        public string Scan_Voucher(string ID)
        {
            string sqlString = "SELECT [dbo].[Scan_Voucher]('" + ID + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
        public void Delete_Voucher(string ID)
        {
            string sqlString = "DELETE FROM cVoucher WHERE idVoucher = " + ID;
            dBMain.ExecuteScalar_void(sqlString, CommandType.Text);
        }
    }
}
