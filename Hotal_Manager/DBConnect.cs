using MySql.Data.MySqlClient;
using System;

namespace Hotal_Manager
{
    
    public class DBConnect
    {
        private MySqlConnection connection =
            new MySqlConnection("server=localhost;port=3306;user id=root;password=;database=hotal_data");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseCon()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}