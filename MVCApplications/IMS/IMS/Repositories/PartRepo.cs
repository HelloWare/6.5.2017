using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories //Data Access Layer, DAL
{
    public class PartRepo
    {
        private IEnumerable<Part> ExecuteReaderWrapper(SqlCommand command)
        {
            //list of partypes to be returned 
            var parts = new List<Part>();
            using (SqlConnection conn = new SqlConnection(RepoUtilities.connectionString))
            {
                conn.Open();
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();//Got data from db
                if (reader.HasRows)//Check if there is data in reader
                {
                    while (reader.Read())//check if there is next row
                    {
                        Part temp = new Part(); //temperory Part placeholder to save each row
                        temp.Id = Convert.ToInt32(reader["Id"]);
                        temp.PartName = Convert.ToString(reader["PartName"]);
                        temp.Description = Convert.ToString(reader["Description"]);
                        temp.Notes = Convert.ToString(reader["Notes"]);
                        temp.PicturePath = Convert.ToString(reader["PicturePath"]);
                        temp.Cost = Convert.ToDouble(reader["Cost"]);
                        temp.IsActive = Convert.ToBoolean(reader["IsActive"]);
                        temp.PartTypeId = Convert.ToInt32(reader["PartTypeId"]);
                        temp.CategoryId = Convert.ToInt32(reader["CategoryId"]);

                        parts.Add(temp);//add each row part to the list
                    }
                }
            }
            return parts;
        }

        public void Insert(Part part)
        {
            string cmdText = "Insert Into Part(Name,Description,PartName,Notes,PicturePath,Cost,IsActive,PartTypeId,CategoryId) Values(@Name,@Description,@PartName,@Notes,@PicturePath,@Cost,@IsActive,@PartTypeId,@CategoryId);";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@PartName", part.PartName);
            cmd.Parameters.AddWithValue("@Description", part.Description);
            cmd.Parameters.AddWithValue("@Notes", part.Notes);
            cmd.Parameters.AddWithValue("@PicturePath", part.PicturePath); cmd.Parameters.AddWithValue("@Cost", part.Cost);
            cmd.Parameters.AddWithValue("@IsActive", part.IsActive); cmd.Parameters.AddWithValue("@PartTypeId", part.PartTypeId);
            cmd.Parameters.AddWithValue("@CategoryId", part.CategoryId); 
            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Update(Part part)
        {
            string cmdText = "Update Part Set Name=@Name,Description=@Description,PartName=@PartName,Notes=@Notes,PicturePath=@PicturePath,Cost=@Cost,IsActive=@IsActive,PartTypeId=@PartTypeId,CategoryId=@CategoryId where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText); cmd.Parameters.AddWithValue("@PartName", part.PartName);
            cmd.Parameters.AddWithValue("@Description", part.Description);
            cmd.Parameters.AddWithValue("@Notes", part.Notes);
            cmd.Parameters.AddWithValue("@PicturePath", part.PicturePath); cmd.Parameters.AddWithValue("@Cost", part.Cost);
            cmd.Parameters.AddWithValue("@IsActive", part.IsActive); cmd.Parameters.AddWithValue("@PartTypeId", part.PartTypeId);
            cmd.Parameters.AddWithValue("@CategoryId", part.CategoryId);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Delete(int id)
        {
            string cmdText = "delete from Part where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public IEnumerable<Part> SelectAll()
        {

            string cmdText = "select * from Part";
            SqlCommand cmd = new SqlCommand(cmdText);

            IEnumerable<Part> parts = ExecuteReaderWrapper(cmd);

            return parts;
        }

        public Part Select(int id)
        {
            string cmdText = "select * from Part where Id = @id";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            IEnumerable<Part> parts = ExecuteReaderWrapper(cmd);

            return parts.FirstOrDefault();
        }

    }
}