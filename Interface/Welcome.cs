using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;
using Kitbox;

namespace Interface
{
    public partial class Welcome : System.Windows.Forms.UserControl
    {
        Form1 form = new Form1();
        MySqlCommand cmd = new MySqlCommand();
        public Welcome()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            if  (textBox1.Text=="Please enter an email before starting")
            {
                MessageBox.Show("You forgot enter an email !!");
            }
            else
            {
                if (form.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`orders` (`clientAdressMail`,`State`) VALUES ('" + textBox1.Text + "','initialized');", form.connection);
                    form.mySqlDataAdapter = new MySqlDataAdapter("SELECT  idOrder FROM  orders WHERE  idOrder = (SELECT MAX(idOrder) FROM orders)", form.connection);

                    cmd.ExecuteNonQuery();
                  

                    DataSet DS = new DataSet();
                    form.mySqlDataAdapter.Fill(DS);

                    Order order = Form1.GetOrder();
                    int currentIdOrder = Convert.ToInt32(DS.Tables[0].Rows[0]["idORder"]);
                    order.SetId(currentIdOrder);
                    this.Controls.Clear();
                    this.Controls.Add(new SpecAllLock());

                }
            }
            
            

        }

      

        private void Admin_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            Login Admin = new Login();
            Admin.ShowDialog();
            
            
            

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";

            form.connection = new MySqlConnection(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
