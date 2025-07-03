using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Configuration;

namespace QLTV
{
    public class Database
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                var adapter = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
