using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories //Data Access Layer, DAL
{
    public class PriceRepo
    {
        private IEnumerable<Price> ExecuteReaderWrapper(SqlCommand command)
        {
            //list of partypes to be returned 
            var prices = new List<Price>();
            using (SqlConnection conn = new SqlConnection(RepoUtilities.connectionString))
            {
                conn.Open();
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();//Got data from db
                if (reader.HasRows)//Check if there is data in reader
                {
                    while (reader.Read())//check if there is next row
                    {
                        Price temp = new Price(); //temperory Price placeholder to save each row
                        temp.Id = Convert.ToInt32(reader["Id"]);
                        temp.PartId = Convert.ToInt32(reader["PartId"]);
                        temp.Name = Convert.ToString(reader["Name"]);
                        temp.MarkUp = Convert.ToDouble(reader["MarkUp"]);

                        prices.Add(temp);//add each row price to the list
                    }
                }
            }
            return prices;
        }



        public void Insert(Price price)
        {
            string cmdText = "Insert Into Price(Name,MarkUp,PartId) Values(@Name,@MarkUp,@PartId);";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", price.Name);
            cmd.Parameters.AddWithValue("@MarkUp", price.MarkUp);
            cmd.Parameters.AddWithValue("@PartId", price.PartId);
            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Update(Price price)
        {
            string cmdText = "Update Price Set Name=@Name, MarkUp=@MarkUp,PartId=@PartId where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Name", price.Name);
            cmd.Parameters.AddWithValue("@Id", price.Id);
            cmd.Parameters.AddWithValue("@PartId", price.PartId);
            cmd.Parameters.AddWithValue("@MarkUp", price.MarkUp);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public void Delete(int id)
        {
            string cmdText = "delete from Price where Id=@Id;";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            RepoUtilities.ExecuteNonQueryWrapper(cmd);
        }

        public IEnumerable<Price> SelectAll()
        {

            string cmdText = "select * from Price";
            SqlCommand cmd = new SqlCommand(cmdText);

            IEnumerable<Price> prices = ExecuteReaderWrapper(cmd);

            return prices;
        }

        public IEnumerable<Price> SelectAllPricesForPart(int partId)
        {

            string cmdText = "select * from Price where PartId=@PartId";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@PartId",partId);

            IEnumerable<Price> prices = ExecuteReaderWrapper(cmd);

            return prices;
        }

        public Price Select(int id)
        {
            string cmdText = "select * from Price where Id = @id";
            SqlCommand cmd = new SqlCommand(cmdText);
            cmd.Parameters.AddWithValue("@Id", id);

            IEnumerable<Price> prices = ExecuteReaderWrapper(cmd);

            return prices.FirstOrDefault();
        }

    }
}