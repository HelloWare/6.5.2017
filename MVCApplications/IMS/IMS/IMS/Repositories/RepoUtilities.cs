using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.Repositories
{
    public static class RepoUtilities
    {
        public static string connectionString = @"Data Source=LAPTOP-08TPTLQQ\;Initial Catalog=IMS;Integrated Security=True";

        public static int ExecuteNonQueryWrapper(SqlCommand command)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                command.Connection = conn;
                return command.ExecuteNonQuery();
            }
        }

        public static int ExecuteScalarWrapperInt(SqlCommand command)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                command.Connection = conn;
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}