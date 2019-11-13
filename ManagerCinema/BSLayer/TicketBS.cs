﻿using ManagerCinema.DBLayer;
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

        public bool insertTicket(int id, int idUser, int idCinema, int idRoomCinema, string nameSeat, string time, string date, int idMovie, int price)
        {
            string sqlString = string.Format("exec insertTicket '{0}','{1}','{2}','{3}', '{4}','{5}','{6}','{7}','{8}'",
                id,idUser,idCinema,idRoomCinema,nameSeat,time,date,idMovie,price);
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
