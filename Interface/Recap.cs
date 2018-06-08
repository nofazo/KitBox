﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Recap : System.Windows.Forms.UserControl
    {

        public Recap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;
            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";
            form.connection = new MySqlConnection(connectionString);
            //form.OpenConnection();
            if (form.OpenConnection() == true)
            {                
                form.mySqlDataAdapter = new MySqlDataAdapter("select * from lockers", form.connection);
                DataSet DS = new DataSet();
                form.mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                                                                                                              //close connection
                form.CloseConnection();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Welcome());
        }
    }
}
