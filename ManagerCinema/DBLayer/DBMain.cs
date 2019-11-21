using System.Data;
using System.Data.SqlClient;

namespace ManagerCinema.DBLayer
{
    class DBMain
    {
        // Chuỗi connStr thể hiện đường dẫn đến Database
        string connStr = "Data Source=.;Initial Catalog=DBSM1;Integrated Security=True";

        // Khởi tạo mặc định các Properties
        SqlConnection connect = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;

        // Hàm khởi tạo, gọi Connection
        public DBMain()
        {
            connect = new SqlConnection(connStr);
            command = connect.CreateCommand();
        }

        // Overwrite hàm khởi tạo dành cho Connection yêu cầu đăng nhập
        public DBMain(string Username, string Password)
        {
            string connStr = "Data Source=.;Initial Catalog=DBSM1;Integrated Security=True; User ID = " + 
                Username + ";Password = " + Password;
            connect = new SqlConnection(connStr);
            command = connect.CreateCommand();
        }

        // Chuỗi strSql chính là câu lệnh SQL Query mà ta muốn thực hiện
        public DataTable ExecuteQueryDataSet(string strSql, CommandType type)
        {
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = strSql;
            command.CommandType = type;
            adapter = new SqlDataAdapter(command);
            DataTable dataSet = new DataTable();
            adapter.Fill(dataSet);
            return dataSet;
        }

        public bool MyExecuteNonQuery(string strSql, CommandType type)
        {
            bool isError = false;
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = strSql;
            command.CommandType = type;
            try
            {
                command.ExecuteNonQuery();
                isError = true;
            }
            catch (SqlException)
            {
            }
            finally
            {
                connect.Close();
            }
            // Trả về True/False tùy thuộc hành động có thành công không
            return isError;
        }
        public string ExecuteScalar(string Query, CommandType type)
        {
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = Query;
            command.CommandType = type;
            SqlCommand cmd1 = new SqlCommand(Query, connect);
            return cmd1.ExecuteScalar().ToString();
        }

        public void ExecuteScalar_void(string Query, CommandType type)
        {
            if (connect.State == ConnectionState.Open) { connect.Close(); }
            connect.Open();
            command.CommandText = Query;
            command.CommandType = type;
            SqlCommand cmd1 = new SqlCommand(Query, connect);
            cmd1.ExecuteScalar();
        }
    }
}
