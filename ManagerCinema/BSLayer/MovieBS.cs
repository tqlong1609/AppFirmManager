using ManagerCinema.DBLayer;
using System.Data;

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
            string sqlString = "SELECT * from getAllMovies()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addMovies(int id, string name, int time, string director, string country,
            string producer, string type, string actor, string date, string content, int price,
            string pathImage)
        {
            string sqlString = string.Format("exec dbo.insertMovie " +
                "@idMovie = '{0}', @name = '{1}', @time = '{2}'," +
                " @director = '{3}', @country = '{4}', @producer = '{5}'," +
                " @type = '{6}', @actor = '{7}', @date = '{8}', @content = '{9}'," +
                "@price = '{10}', @image = '{11}'", id, name, time, director, country, producer,
                type, actor, date, content, price, pathImage);

            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }

        public DataTable getInforTicketFromIdMovies(int id)
        {
            string sqlString = string.Format("select * from getInforTicketFromIdMovies({0})", id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable getInforSeatFromIdCinema(int id)
        {
            string sqlString = string.Format("select * from getInforSeatFromIdCinema({0})", id);
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataTable Search_Movie_Id(string id)
        {
            string sqlString = "SELECT * FROM Movie WHERE IdMovie = " + id;
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool Delete_Movie(string id)
        {
            string sqlString = "Delete From Movie Where idMovie=" + id;
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
