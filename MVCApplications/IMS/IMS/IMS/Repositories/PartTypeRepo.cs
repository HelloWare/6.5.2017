using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories //Data Access Layer, DAL
{
    public class PartTypeRepo
    {
        private IEnumerable<PartType> ExecuteReaderWrapper(SqlCommand command)
        {
            //list of partypes to be returned 
            var partTypes = new List<PartType>();
            using (SqlConnection conn = new SqlConnection(RepoUtilities.connectionString))
            {
                conn.Open();
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();//Got data from db
                if (reader.HasRows)//Check if there is data in reader
                {
                    while (reader.Read())//check if there is next row
                    {
                        PartType temp = new PartType(); //temperory PartType placeholder to save each row
                        temp.Id = Convert.ToInt32(reader["Id"]);
                        temp.Name = Convert.ToString(reader["Name"]);

                        partTypes.Add(temp);//add each row partType to the list
                    }
                }
            }
            return partTypes;
        }

        public void Insert(PartType partType)
        {
            string cmdText = "Insert Into PartType(Name) Values(@Name);";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", partType.Name);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Update(PartType partType)
        {
            string cmdText = "Update PartType Set Name=@Name where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", partType.Name);
            cmd.Parameters.AddWithValue("@Id", partType.Id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Delete(int id)
        {
            string cmdText = "delete from PartType where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public IEnumerable<PartType> SelectAll()
        {

            string cmdText = "select * from PartType";
            SqlCommand cmd = new SqlCommand(cmdText);

            IEnumerable<PartType> partTypes = ExecuteReaderWrapper(cmd);

            return partTypes;
        }

        public PartType Select(int id)
        {
            string cmdText = "select * from PartType where Id = @id";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            IEnumerable<PartType> partTypes = ExecuteReaderWrapper(cmd);

            return partTypes.FirstOrDefault();
        }

    }
}