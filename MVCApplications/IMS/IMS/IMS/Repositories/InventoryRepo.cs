using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories //Data Access Layer, DAL
{
    public class InventoryRepo
    {
        private IEnumerable<Inventory> ExecuteReaderWrapper(SqlCommand command)
        {
            //list of partypes to be returned 
            var inventorys = new List<Inventory>();
            using (SqlConnection conn = new SqlConnection(RepoUtilities.connectionString))
            {
                conn.Open();
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();//Got data from db
                if (reader.HasRows)//Check if there is data in reader
                {
                    while (reader.Read())//check if there is next row
                    {
                        Inventory temp = new Inventory(); //temperory Inventory placeholder to save each row
                        temp.Id = Convert.ToInt32(reader["Id"]);
                        temp.Location = Convert.ToString(reader["Location"]);
                        temp.Quantity = Convert.ToDouble(reader["Quantity"]);
                        temp.PartId = Convert.ToInt32(reader["PartId"]);

                        inventorys.Add(temp);//add each row inventory to the list
                    }
                }
            }
            return inventorys;
        }

        public void Insert(Inventory inventory)
        {
            string cmdText = "Insert Into Inventory(Location,Quantity,PartId) Values(@Location,@Quantity,@PartId);";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Location", inventory.Location);
            cmd.Parameters.AddWithValue("@Quantity", inventory.Quantity);
            cmd.Parameters.AddWithValue("@PartId", inventory.PartId);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Update(Inventory inventory)
        {
            string cmdText = "Update Inventory Set Location=@Location,Quantity = @Quantity, PartId=@PartId where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Location", inventory.Location);
            cmd.Parameters.AddWithValue("@Quantity", inventory.Quantity);
            cmd.Parameters.AddWithValue("@PartId", inventory.PartId);
            cmd.Parameters.AddWithValue("@Id", inventory.Id);
            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Delete(int id)
        {
            string cmdText = "delete from Inventory where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public IEnumerable<Inventory> SelectAll()
        {

            string cmdText = "select * from Inventory";
            SqlCommand cmd = new SqlCommand(cmdText);

            IEnumerable<Inventory> inventorys = ExecuteReaderWrapper(cmd);

            return inventorys;
        }

        public Inventory Select(int id)
        {
            string cmdText = "select * from Inventory where Id = @id";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            IEnumerable<Inventory> inventorys = ExecuteReaderWrapper(cmd);

            return inventorys.FirstOrDefault();
        }

        public IEnumerable<Inventory> GetInventoriesForPart(int partId)
        {

            string cmdText = "select * from Inventory where PartId = @PartId";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@PartId", partId);

            IEnumerable<Inventory> inventorys = ExecuteReaderWrapper(cmd);

            return inventorys;
        }


    }
}