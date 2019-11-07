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
            string sqlString = "SELECT * from getAllMovies()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addMovies(int id, string name, int time, string director, string country,
            string producer, string type, string actor, string date, string content,int price,
            string pathImage)
        {
            string sqlString = String.Format("exec dbo.insertMovie " +
                "@idMovie = '{0}', @name = '{1}', @time = '{2}'," +
                " @director = '{3}', @country = '{4}', @producer = '{5}'," +
                " @type = '{6}', @actor = '{7}', @date = '{8}', @content = '{9}'," +
                "@price = '{10}', @image = '{11}'",id,name,time,director,country,producer,
                type,actor,date,content,price,pathImage);

            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataTable getInforTicketFromIdMovies(int id)
        {
            string sqlString = String.Format("select * from getInforTicketFromIdMovies({0})",id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
    }
}
