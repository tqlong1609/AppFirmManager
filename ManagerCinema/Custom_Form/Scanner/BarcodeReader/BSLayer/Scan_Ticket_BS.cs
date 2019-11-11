using System.Data;
using BarcodeReaderApp.DBLayer;

namespace BarcodeReaderApp.BSLayer
{
    class Scan_Ticket_BS
    {
        private DBMain dBMain;

        public Scan_Ticket_BS()
        {
            dBMain = new DBMain();
        }

        public string Scan_Ticket(string ID)
        {
            string sqlString = "SELECT [dbo].[Scan_Ticket]('" + ID + "')";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }
    }
}
