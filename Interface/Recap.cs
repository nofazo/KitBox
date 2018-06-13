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
            

            
            textBox1.AppendText("Your cupboard is complete , you choose  "+Form1.GetListofLocker().Count()+"  locker(s) : \n");
            int i = 1;
            foreach (Kitbox.Locker locker in Form1.GetListofLocker())
            {
                //remplir le textbox avec les valeurs des objects existants
                textBox1.AppendText(" "+i+ " : One "  + locker.GetColor()+ "  locker. \n");

                foreach (Kitbox.Accessory accessory in locker.GetAccessoryList())
                {
                    textBox1.AppendText(" " + accessory.GetAccessType() + " ");
                }
                                       
                i += 1;

            }

        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                Order order = Form1.GetOrder();
                int idOrder = order.GetidOrder();
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`orders` SET State='Completed' WHERE idOrder ='" + idOrder + "'", form.connection);

                cmd.ExecuteNonQuery();

            }
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
