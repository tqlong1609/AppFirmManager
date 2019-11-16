﻿using System.Data;
using System.Data.SqlClient;

namespace ManagerCinema.DBLayer
{
    class DBMain
    {
        // NOTE: edit connstr when run
        string connStr = "Data Source=.;Initial Catalog=DBSM1;Integrated Security=True";
        SqlConnection connect = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;

        public DBMain()
        {
            connect = new SqlConnection(connStr);
            command = connect.CreateCommand();
        }

        // error
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
