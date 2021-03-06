﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student lastStudent;
        List<Student> students = new List<Student>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-E4GLUAC2\MSSQLSERVER01;Initial Catalog=sql_demo;"
        + "Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //connection.ConnectionString = connectionString;

                connection.Open();

                //MessageBox.Show("State: "+connection.State);
                //MessageBox.Show("ConnectionString: "+
                //    connection.ConnectionString);

                string query = "SELECT * FROM Student;";

                SqlCommand cmd = new SqlCommand(query, connection);

                ////Update, Insert, Delete
                //cmd.ExecuteNonQuery();
                ////Select
                //cmd.ExecuteReader();
                ////Count(), Avg(),Sum() ...
                //cmd.ExecuteScalar();

                SqlDataReader reader = cmd.ExecuteReader();
                /*
                0   1   2           index
                id  fn  ln          name
                1   k   k
                2   d   d
                3   h   h
                */
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student std = new Student();
                        //std.Id = reader.GetInt32(0);
                        std.Id = Convert.ToInt32(reader["Id"]);
                        std.FirstName = reader.GetString(1);
                        std.LastName = reader.GetString(2);

                        students.Add(std);

                        lastStudent = std;
                        //show last name
                        //MessageBox.Show(reader.GetString(2));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }
                reader.Close();

            }
            ShowStudents();

        }

        private void ShowStudents()
        {
            foreach (Student student in students)
            {
                listBox1.Items.Add(student.FirstName + " " + student.LastName);
            }
        }
    }
}
