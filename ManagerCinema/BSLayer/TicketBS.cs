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

        public TicketBS(string Username, string Password)
        {
            dBMain = new DBMain(Username, Password);
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllTicket()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable loadData(string ID)
        {
            string sqlString = "SELECT * from Ticket WHERE idTicket = " + ID;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool insertTicket(int id, int idUser, int idCinema, int idRoomCinema, string nameSeat, string time, string date, int idMovie, int price)
        {
            string sqlString = string.Format("exec insertTicket '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",
                id,idUser,idCinema,idRoomCinema,nameSeat,time,date,idMovie,price);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataTable Search_Ticket_Id(string id)
        {
            string sqlString = "select idTicket, Time, Date, Price from Ticket_VIEW_Employee where idTicket = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool insert_Ticket(string id, string idUser, string idCinema, string idRoomCinema, string nameSeat, string time, string date, string idMovie, string price)
        {
            string sqlString = string.Format("exec insertTicket {0},{1},{2},{3},'{4}','{5}','{6}',{7},{8}",
                id, idUser, idCinema, idRoomCinema, nameSeat, time, date, idMovie, price);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
