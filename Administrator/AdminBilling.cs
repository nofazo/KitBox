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
using System.IO;

namespace WindowsFormsApp7
{
    public partial class AdminBilling : UserControl
    {
        public string CmdID;
        Template form = new Template();

        public AdminBilling()
        {
            InitializeComponent();
        }

        public int GetFkOrder()
        {
            int FkOrder = Convert.ToInt32(comboBoxCmdID.Text);
            return FkOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.OpenConnection();
            //supprime les pièces dans la base de donnée 
            DeleteParts();
            //renvoie la facture
            
            CupBoard cupBoard = form.GetCupBoard(form.connection, GetFkOrder());
            int lockerNumber = cupBoard.GetLockerList().Count();
            string colorExtrusion = cupBoard.GetExtrusion().GetColor();

            string path = @"/Users/Fatine/source/Bill.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("BILL"); //ajouter le prénom et la date?
                sw.WriteLine(" ");
                sw.WriteLine("You bought 1 cupboard with " + lockerNumber + " locker(s).");
                sw.WriteLine(" ");

                int i = 1;
                foreach (Locker locker in cupBoard.GetLockerList())
                {
                    sw.WriteLine("Locker n°" + i + ": ");
                    sw.WriteLine("Color: " + locker.GetColor() + "   Price: " + locker.GetPrice(form.connection));
                    if (locker.HasDoor())
                        if (locker.GetDoor().GetColor() == "glass")
                            sw.WriteLine(" This locker has 2 glass doors");
                        else
                            sw.WriteLine(" This locker has 2 " + locker.GetDoor().GetColor() + " wood doors ");
                    else
                        sw.WriteLine(" ");

                    sw.WriteLine(" ");
                    i++;
                }

                sw.WriteLine("Corner : ");
                sw.WriteLine("Color: " + colorExtrusion + "   Price : " + cupBoard.GetExtrusion().GetPrice(form.connection));

                sw.WriteLine(" ");

                sw.WriteLine("Total : " + cupBoard.GetPrice(form.connection) + "euros");

            }

            form.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                //Afficher également les détails
                form.mySqlDataAdapter = new MySqlDataAdapter("select * from lockers where FkOrder= '" + comboBoxCmdID.Text + "';", form.connection);
                DataSet DS = new DataSet();
                form.mySqlDataAdapter.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

                //close connection
                form.CloseConnection();


            }



        }

        private void comboBoxCmdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmdID = comboBoxCmdID.Text;
        }

        private void AdminBilling_Load(object sender, EventArgs e)
        {
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";

            form.connection = new MySqlConnection(connectionString);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AdminMenu());
        }

        public string GetDimension(double height, double width, double depth)
        {
            string sheight = Convert.ToString(height);
            string swidth = Convert.ToString(width);
            string sdepth = Convert.ToString(depth);

            string dim = sheight + "x" + swidth + "x" + sdepth + " cm ";
            return dim;
        }

        public string GetRealColor(string color)
        {
            if (color != "")
                return color;
            else
                return "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form.OpenConnection();

            CupBoard cupBoard = form.GetCupBoard(form.connection, GetFkOrder());
            int lockerNumber = cupBoard.GetLockerList().Count();
            string colorExtrusion = cupBoard.GetExtrusion().GetColor();

            string path = @"/Users/Fatine/source/DetailParts.txt";

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("DETAIL PARTS");
                sw.WriteLine(" ");
                sw.WriteLine("there is in this order:  1 cupboard with " + lockerNumber + " locker(s).");
                sw.WriteLine(" ");

                int i = 1;
                foreach (Locker locker in cupBoard.GetLockerList())
                {
                    sw.WriteLine("Locker n°" + i + " ");
                    sw.WriteLine("Color: " + locker.GetColor() + "   Price: " + locker.GetPrice(form.connection) + " euros");
                    sw.WriteLine("   Parts : ");

                    foreach (Accessory access in locker.GetAccessoryList())
                    {
                        string availability;
                        if (access.GetInstock(form.connection) > 1)
                            availability = "available";
                        else
                            availability = "not available";

                        sw.WriteLine("    Type : " + access.GetAccessType() + "   color : " + GetRealColor(access.GetColor()) + "   dimensions : " + GetDimension(access.GetHeight(), access.GetWidth(), access.GetDepth()) + "   price : " + access.GetPrice(form.connection) + " euros" + "   " + availability);
                    }

                    sw.WriteLine(" ");
                    i++;
                }

                Extrusion extrusion = cupBoard.GetExtrusion();
                string availabilityC;
                if (extrusion.GetInstock(form.connection) > 1)
                    availabilityC = "available";
                else
                    availabilityC = "not available";

                sw.WriteLine("Corner ");
                sw.WriteLine("Color: " + colorExtrusion + "   height : " + extrusion.GetHeight() + "   Price : " + extrusion.GetPrice(form.connection) + " euros " + "   " + availabilityC);

                sw.WriteLine(" ");

                sw.WriteLine("Total : " + cupBoard.GetPrice(form.connection) + " euros");

            }

            form.CloseConnection();
        }

        public void DeleteParts()
        {
            CupBoard cupBoard = form.GetCupBoard(form.connection,GetFkOrder());
            string idPart = "";
            int numberOfPart = 0;
            int InStock = 0;

            foreach (Kitbox.Locker locker in cupBoard.GetLockerList())
            {
                foreach (Accessory access in locker.GetAccessoryList())
                {
                    //Prendre les references de toutes les parts d'un locker 

                    MySqlDataReader reader;
                    MySqlCommand command = new MySqlCommand("SELECT Idpart FROM `kitboxdb2.0`.`parts` WHERE ref='" + access.GetRefDB() + "'AND height='" + Convert.ToString(access.GetHeight()) + "'AND width='" + Convert.ToString(access.GetWidth()) + "'AND depth='" + Convert.ToString(access.GetDepth()) + "'AND color='" + access.GetColorDB(access.GetColor()) + "'", form.connection);
                    reader = command.ExecuteReader();

                                   
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

                }
            }
            foreach (Kitbox.Locker locker in cupBoard.GetLockerList())
            {
                foreach (Accessory access in locker.GetAccessoryList())
                {

                    MySqlDataReader reader3;
                    MySqlCommand command3 = new MySqlCommand("SELECT PartForLocker FROM `kitboxdb2.0`.`parts` WHERE ref='" + access.GetRefDB() + "'AND height='" + Convert.ToString(access.GetHeight()) + "'AND width='" + Convert.ToString(access.GetWidth()) + "'AND depth='" + Convert.ToString(access.GetDepth()) + "'AND color='" + access.GetColorDB(access.GetColor()) + "'", form.connection);
                    reader3 = command3.ExecuteReader();                  

                    if (reader3.HasRows)
                    {
                        while (reader3.Read())

                        {
                            numberOfPart = Convert.ToInt32(reader3.GetString(0));

                        }
                    }
                    else
                    {
                        MessageBox.Show("there is no idPart in the datareader");
                    }

                    reader3.Close();

                }
            }
            foreach (Kitbox.Locker locker in cupBoard.GetLockerList())
            {
                foreach (Accessory access in locker.GetAccessoryList())
                {

                    MySqlDataReader reader4;
                    MySqlCommand command4 = new MySqlCommand("SELECT Instock FROM `kitboxdb2.0`.`parts` WHERE ref='" + access.GetRefDB() + "'AND height='" + Convert.ToString(access.GetHeight()) + "'AND width='" + Convert.ToString(access.GetWidth()) + "'AND depth='" + Convert.ToString(access.GetDepth()) + "'AND color='" + access.GetColorDB(access.GetColor()) + "'", form.connection);
                    reader4 = command4.ExecuteReader();

                    if (reader4.HasRows)
                    {
                        while (reader4.Read())

                        {
                            InStock = Convert.ToInt32(reader4.GetString(0));

                        }
                    }
                    else
                    {
                        MessageBox.Show("there is no idPart in the datareader");
                    }

                    reader4.Close();

                }
            }

            //retirer les parts liés à la commande.
            MySqlCommand command2 = new MySqlCommand("Update `kitboxdb2.0`.`parts` SET Instock= '" + (InStock - numberOfPart) + "' WHERE Idpart='" + idPart + "'", form.connection);
            command2.ExecuteNonQuery();
        }
    }
}