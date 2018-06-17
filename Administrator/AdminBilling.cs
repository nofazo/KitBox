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
                sw.WriteLine("You bought 1 cupBoard of " + lockerNumber + "locker(s).");
                sw.WriteLine(" ");


                foreach (Locker locker in cupBoard.GetLockerList())
                {
                    int i = 0;
                    sw.WriteLine("Locker n°" + i + ": ");
                    sw.WriteLine("Color: " + locker.GetColor() + "   Price: " + locker.GetPrice(form.connection));   // sprint 3:faire distinction entre casier avec porte et casier sans porte
                    //Ajouter accessoire non important : Door
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
    }
}
