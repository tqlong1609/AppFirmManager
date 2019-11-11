using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class TicketBS
    {
        private DBMain dBMain;

        public TicketBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllTicket()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
