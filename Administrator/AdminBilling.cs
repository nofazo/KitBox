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

            CupBoard cupBoard = form.GetCupBoard(form.connection, GetFkOrder());
            int lockerNumber = cupBoard.GetLockerList().Count();
            string colorExtrusion = cupBoard.GetExtrusion().GetColor();

            string path = @"/Users/User/source/Bill.txt";

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
                form.mySqlDataAdapter = new MySqlDataAdapter("select * from lockers where FkOrder= '"+comboBoxCmdID.Text+"';", form.connection);
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

            string path = @"/Users/User/source/DetailParts.txt";

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

                    foreach(Accessory access in locker.GetAccessoryList())
                    {
                        string availability;
                        if (access.GetInstock(form.connection) > 1)
                            availability = "available";
                        else
                            availability = "not available";
                        
                        sw.WriteLine("    Type : " + access.GetAccessType() + "   color : "+ GetRealColor(access.GetColor()) + "   dimensions : " + GetDimension(access.GetHeight(), access.GetWidth(), access.GetDepth()) + "   price : " + access.GetPrice(form.connection) + " euros"+ "   " + availability);
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
                sw.WriteLine("Color: " + colorExtrusion + "   height : " + extrusion.GetHeight() + "   Price : " + extrusion.GetPrice(form.connection) + " euros " +"   " + availabilityC);

                sw.WriteLine(" ");

                sw.WriteLine("Total : " + cupBoard.GetPrice(form.connection) + " euros");

            }

            form.CloseConnection();
        }
    }
}
