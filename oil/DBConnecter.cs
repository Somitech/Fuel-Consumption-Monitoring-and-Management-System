using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace oil
{
    class DBConnecter
    {
        private static DBConnecter instance;
        private static SqlConnection conn;
        private DBConnecter() 
        {
           conn = new SqlConnection(ConnectionString());
        }

        public static DBConnecter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBConnecter();
                }
                return instance;
            }

        }

        public string makeDate(string day, string month, string year)
        {
            return year + "-" + month + "-" + day;
        }

        public DataSet select(string query)
        { 
            
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public void update(string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void insert(string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void delete(string query)
        {
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public bool checkUser(string user, string pass)
        {
            string query = @"select userName from UserLogin where userName = '" + user + "' and pass = '" + pass + "'";
            DataSet ds = select(query);
            if (ds.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }

        protected static string ConnectionString()
        {
            string conString = string.Empty;
            try
            {
                conString = ConfigurationManager.AppSettings.Get("ConnectionString");

            }//end try
            catch (Exception ex)
            {
                
            }//end catch
            return conString;
        }//end 

    }
}
