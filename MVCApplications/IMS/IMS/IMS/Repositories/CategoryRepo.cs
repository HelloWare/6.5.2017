using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories //Data Access Layer, DAL
{
    public class CategoryRepo
    {
        private IEnumerable<Category> ExecuteReaderWrapper(SqlCommand command)
        {
            //list of partypes to be returned 
            var categorys = new List<Category>();
            using (SqlConnection conn = new SqlConnection(RepoUtilities.connectionString))
            {
                conn.Open();
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();//Got data from db
                if (reader.HasRows)//Check if there is data in reader
                {
                    while (reader.Read())//check if there is next row
                    {
                        Category temp = new Category(); //temperory Category placeholder to save each row
                        temp.Id = Convert.ToInt32(reader["Id"]);
                        temp.Name = Convert.ToString(reader["Name"]);
                        temp.Description = Convert.ToString(reader["Description"]);

                        categorys.Add(temp);//add each row category to the list
                    }
                }
            }
            return categorys;
        }

        public void Insert(Category category)
        {
            string cmdText = "Insert Into Category(Name,Description) Values(@Name,@Description);";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Description", category.Description);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Update(Category category)
        {
            string cmdText = "Update Category Set Name=@Name, Description=@Description where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", category.Name);
            cmd.Parameters.AddWithValue("@Id", category.Id);
            cmd.Parameters.AddWithValue("@Description", category.Description);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Delete(int id)
        {
            string cmdText = "delete from Category where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public IEnumerable<Category> SelectAll()
        {

            string cmdText = "select * from Category";
            SqlCommand cmd = new SqlCommand(cmdText);

            IEnumerable<Category> categorys = ExecuteReaderWrapper(cmd);

            return categorys;
        }

        public Category Select(int id)
        {
            string cmdText = "select * from Category where Id = @id";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            IEnumerable<Category> categorys = ExecuteReaderWrapper(cmd);

            return categorys.FirstOrDefault();
        }

    }
}