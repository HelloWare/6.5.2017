using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InsertDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //invalid input
            if (FirstNameBox.Text == "" || LastNameBox.Text == "")
            {
                MessageBox.Show("FirstName and LastName Can't be empty!");
                return;
            }

            string connectionString = @"Data Source=LAPTOP-E4GLUAC2\MSSQLSERVER01;Initial Catalog=sql_demo;"
       + "Integrated Security=true;";

            //1. Build DB connection
            SqlConnection conn = new SqlConnection(connectionString);

            //SqlConnection connection = new SqlConnection();
            //connection.ConnectionString = connectionString;

            //2. Open Connection
            conn.Open();

            //3. Create SqlCommand object
            string cmdTxt = "Insert into Student values(" + IdBox.Value + ",'" + FirstNameBox.Text + "','"+LastNameBox.Text+"');";

            string cmdTextSafe = "Insert into Student values(@id,@firstName,@lastName);";
            //    //using Property to pass CommandText 
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = cmdTxt;
            //cmd.Connection = conn;

            ////using constructor to pass CommandText
            //SqlCommand command = new SqlCommand(cmdTxt);
            //command.Connection = conn;

            //using constructor to pass CommandText & Connection
            SqlCommand sqlCmd = new SqlCommand(cmdTextSafe, conn);
            sqlCmd.Parameters.AddWithValue("@id", IdBox.Value);
            sqlCmd.Parameters.AddWithValue("@firstName", FirstNameBox.Text);
            sqlCmd.Parameters.AddWithValue("@lastName", LastNameBox.Text);

            int affectedRow = sqlCmd.ExecuteNonQuery();
            if (affectedRow == 1)
            {
                MessageBox.Show("Student Created!");
            }

            //5. Close the connection
            conn.Close();

        }
    }
}
