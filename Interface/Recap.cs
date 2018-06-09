using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kitbox;

namespace Interface
{
    public partial class Recap : System.Windows.Forms.UserControl
    {
        Form1 form = new Form1();
        public Recap()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            
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
                form.mySqlDataAdapter = new MySqlDataAdapter("SELECT  FkOrder,idLocker, color FROM   lockers WHERE  FkOrder = (SELECT MAX(FkOrder) FROM lockers)", form.connection);
                DataSet DS = new DataSet();
                form.mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                                                                                                              //close connection
                form.CloseConnection();

            
            }
            int NbrLockers= dataGridView1.Rows.Count - 1 ;
            textBox1.AppendText("Votre armoire sera composée de "+NbrLockers+" casiers : " + Environment.NewLine);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Welcome());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                Order order = Form1.GetOrder();
                int idOrder = order.GetidOrder();
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`orders` SET State='Completed' WHERE idOrder ='" + idOrder + "'", form.connection);

                cmd.ExecuteNonQuery();

            }
        }
    }
}
