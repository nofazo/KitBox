using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitbox;
using MySql.Data.MySqlClient;

namespace Interface
{
    public partial class Extrusions : System.Windows.Forms.UserControl
    {
        Form1 form = new Form1();
        Order order = Form1.GetOrder();
        CupBoard cupBoard = Form1.GetCupBoard();
        double extrusionHeight = Form1.GetCupBoard().GetTotalHeight();

        public Extrusions()
        {
            InitializeComponent();
            
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            string color = extrusionColor.Text;
                      
            Extrusion extrusion = new Extrusion(color, extrusionHeight);
            cupBoard.SetExtrusion(extrusion);
            if (form.OpenConnection() == true)
            {
                
                int idOrder = order.GetIdOrder();
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`orders` SET State='Completed' WHERE idOrder ='" + idOrder + "'", form.connection);

                cmd.ExecuteNonQuery();
                order.SetState("Completed");
            }
            this.Controls.Clear();
            this.Controls.Add(new Recap());
        }

        private void extrusionColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            this.Controls.Add(new Locker());
        }

        private void Extrusions_Load(object sender, EventArgs e)
        {
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;
            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";
            form.connection = new MySqlConnection(connectionString);

            

            if (order.GetState() == "Completed")
            {
                extrusionColor.Text = cupBoard.GetExtrusion().GetColor();

            }
        }
    }
}
