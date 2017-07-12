using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAdapterDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=LAPTOP-E4GLUAC2\MSSQLSERVER01;Initial Catalog=sql_demo;"
       + "Integrated Security=true;";
            //This is not a good practice
            string query = "SELECT FirstName,LastName FROM Student;";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                DataSet students = new DataSet();

                sqlDataAdapter.Fill(students, "Student");

                //dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = students.Tables[0];
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
