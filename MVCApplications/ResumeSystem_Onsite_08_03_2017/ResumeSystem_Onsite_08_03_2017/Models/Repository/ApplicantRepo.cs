using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ResumeSystem_Onsite_08_03_2017.Models.Repository
{
    public class ApplicantRepo
    {
        public List<Applicants> SelectAll()
        {
            List<Applicants> applicantsToReturn = new List<Applicants>();

            string connectionString = @"Data Source=ZWXU-LAPTOP\SQLEXPRESS;Initial Catalog=ResumeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string cmdText = "select * from Applicants";
                SqlCommand cmd = new SqlCommand(cmdText, conn);

               SqlDataReader reader =  cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                        Applicants temp = new Applicants();
                        temp.Id = (Int32)reader["id"];
                        temp.FirstName = reader["FirstName"].ToString();
                        temp.LastName = reader["LastName"].ToString();
                        temp.Email = reader["Email"].ToString();

                        applicantsToReturn.Add(temp);
                    }
                }
            }
            return applicantsToReturn;
        }

        public void SaveApplicantToDb(Applicants applicants)
        {
            string connectionString = @"Data Source=ZWXU-LAPTOP\SQLEXPRESS;Initial Catalog=ResumeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string cmdText = "insert into Applicants(FirstName,LastName,Email) values(@firstname,@lastname,@email)";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@firstname", applicants.FirstName);
                cmd.Parameters.AddWithValue("@lastname", applicants.LastName);
                cmd.Parameters.AddWithValue("@email", applicants.Email);

                cmd.ExecuteNonQuery();
            }

        }
        public void DeleteApplicantFromDb(int id)
        {
            string connectionString = @"Data Source=ZWXU-LAPTOP\SQLEXPRESS;Initial Catalog=ResumeSystem;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string cmdText = "delete from Applicants where id=@id";
                SqlCommand cmd = new SqlCommand(cmdText, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

        }
    }
}