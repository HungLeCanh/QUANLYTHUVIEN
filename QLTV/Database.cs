using System.Data.SqlClient;
using System;
using System.Data;
using System.Configuration;

namespace QLTV
{
    public class Database
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C_sharp\Nhom4_QUANLYTHUVIEN\QLTV\QuanLyThuVien.mdf;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                var adapter = new SqlDataAdapter(cmd);
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
                var cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string query)
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(query, conn);
                return cmd.ExecuteScalar();
            }
        }
    }
}