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
            string producer, string type, string actor, string date, string content, string timeStart,int price,
            string pathImage)
        {
            string sqlString = String.Format("exec dbo.insertMovie " +
                "@idMovie = '{0}', @name = '{1}', @time = '{2}'," +
                " @director = '{3}', @country = '{4}', @producer = '{5}'," +
                " @type = '{6}', @actor = '{7}', @date = '{8}', @content = '{9}'," +
                " @timeStart = '{10}', @price = '{11}', @image = '{12}'",id,name,time,director,country,producer,
                type,actor,date,content,timeStart,price,pathImage);

            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
