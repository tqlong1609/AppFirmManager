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
        string sqlString;

        public MovieBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "exec getAllMovies";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addMovies(int id, string name, int time, string director, string country, 
            string producer, string type, string actor, string date, string content, string timeStart,
            string pathImage)
        {
 //           exec dbo.insertMovie @idMovie = '13', @name = '13', @time = '13', @director = '13', @country = '13',
 //@producer = '13', @type = '13', @actor = '13', @date = '13', @content = '13', @timeStart = '13', @price = '13', @image = '13'
        }
    }
}
