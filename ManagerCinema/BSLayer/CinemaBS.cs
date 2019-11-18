﻿using ManagerCinema.DBLayer;
using System.Data;

namespace ManagerCinema.BSLayer
{
    class CinemaBS
    {
        private DBMain dBMain;
        public CinemaBS()
        {
            dBMain = new DBMain();
        }

        public DataTable loadData()
        {
            string sqlString = "SELECT * from getAllCinema()";
            return dBMain.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        public string isExisted(string id)
        {
            string sqlString = "select dbo.Check_Cinema(" + id + ")";
            return dBMain.ExecuteScalar(sqlString, CommandType.Text);
        }

        public void Add_Cinema(string id, string name, string address, string count, string open, string close)
        {
            string sqlString = "insert into Cinema Values(" + id + "," + name + "," + address + "," + count + "," + open + "," + close + ")";
            dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
        public bool Delete_Cinema(string id)
        {
            string sqlString = "Delete From Cinema Where idCinema=" + id;
            return dBMain.MyExecuteNonQuery(sqlString, CommandType.Text);
        }
    }
}
