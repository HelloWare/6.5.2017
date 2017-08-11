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
        public static string connectionString = @"Data Source=ZWXU-LAPTOP\SQLEXPRESS;Initial Catalog=IMS;Integrated Security=True";

        public static int ExecuteNonQueryWrapper(SqlCommand command)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                command.Connection = conn;
                return command.ExecuteNonQuery();
            }
        }
    }
}