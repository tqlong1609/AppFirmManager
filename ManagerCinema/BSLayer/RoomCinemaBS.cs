using ManagerCinema.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.BSLayer
{
    public class RoomCinemaBS
    {
        private DBMain dBMain;

        public RoomCinemaBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllRoomCinema()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
