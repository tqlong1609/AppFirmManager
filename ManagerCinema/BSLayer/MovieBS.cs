using ManagerCinema.DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerCinema.BSLayer
{
    public class MovieBS
    {
        private DBMain dBMain;

        public MovieBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "exec getAllMovies";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
