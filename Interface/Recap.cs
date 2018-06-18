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
        Order order = Form1.GetOrder();

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
                                       
                i += 1;
            }
            //Affiche le prix total pour vérification
            if (form.OpenConnection() == true)
            {
                double price = Form1.GetCupBoard().GetPrice(form.connection);
                textBox1.AppendText("Total: " + Convert.ToString(price) + " .");
            }
            
            
            
        }
       


        private void button2_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {              
                int idOrder = order.GetIdOrder();
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`orders` SET State='Confirmed' WHERE idOrder ='" + idOrder + "'", form.connection);
                order.SetState("Confirmed");
                cmd.ExecuteNonQuery();
            }

            

            //Affiche idOrder
            MessageBox.Show("Order confirmed ! Here is your order number : " +Convert.ToString(order.GetIdOrder()) + ".   Please communicate it to the storekeeper.");

            CompleteLinkedTable();

            this.Controls.Clear();
            this.Controls.Add(new Welcome());
        }

        public void CompleteLinkedTable()
        {
            CupBoard cupBoard = Form1.GetCupBoard();

            foreach (Kitbox.Locker locker in cupBoard.GetLockerList())
            {
                foreach (Accessory access in locker.GetAccessoryList())
                {
                    //Prendre les references de toutes les parts d'un locker 

                    MySqlDataReader reader;
                    MySqlCommand command = new MySqlCommand("SELECT Idpart FROM `kitboxdb2.0`.`parts` WHERE ref='" + access.GetRefDB() + "'AND height='" + Convert.ToString(access.GetHeight()) + "'AND width='" + Convert.ToString(access.GetWidth()) + "'AND depth='" + Convert.ToString(access.GetDepth()) + "'AND color='" + access.GetColorDB(access.GetColor()) + "'", form.connection);
                    reader = command.ExecuteReader();

                    string idPart = "";

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            idPart = reader.GetString(0);
                        }
                    }
                    else
                    {
                        MessageBox.Show("there is no idPart in the datareader");
                    }

                    reader.Close();

                    //insérer les IDPARTS dans la table linked, ainsi on sait quel type de part est concerné pour chaque locker --> facile pour faire -1 
                    MySqlCommand command2 = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`linked` (FkkOrder, FkkLocker,`FkkPart`) VALUES ('" + order.GetIdOrder() + " ', '" + Convert.ToString(locker.GetID()) + "', '" + idPart + "');", form.connection);
                    command2.ExecuteNonQuery();                   
                }
            }

            

            //Ajout de extrusion dans linked : une seule fois
            Extrusion extrusion = cupBoard.GetExtrusion();
            double extrusionHeight = 0;
            if (extrusion.IsCut(extrusion.GetHeight()))
            {
                extrusionHeight = extrusion.GetExistingTopHeight(extrusion.GetHeight());
            }
            else
            {
                extrusionHeight = extrusion.GetHeight();
            }

            string refcor = "Cornières";
            MySqlDataReader reader3;
            MySqlCommand command3 = new MySqlCommand("SELECT Idpart FROM `kitboxdb2.0`.`parts` WHERE ref='" + refcor + "'AND height='" + Convert.ToString(extrusionHeight) + "'AND color='" + extrusion.GetColorDB(extrusion.GetColor()) + "'", form.connection);
            reader3 = command3.ExecuteReader();

            string idCor = "";

            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    idCor = reader3.GetString(0);
                }
            }
            else
            {
                MessageBox.Show("there is no extrusion in the datareader");
            }

            reader3.Close();

            //prendre nptqel id de locker
            int fkkLocker = cupBoard.GetLockerList()[0].GetID();
            MySqlCommand command4 = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`linked` (FkkOrder, FkkLocker,`FkkPart`) VALUES ('" + order.GetIdOrder() + "', '" + fkkLocker + "', '" + idCor + "');", form.connection);
            command4.ExecuteNonQuery();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Extrusions());
        }
    }
}
