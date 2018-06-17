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

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"/Users/User/source/Bill.txt";

            using (StreamWriter sw = File.CreateText(path))

            {

                //foreach (Locker locker in cubBoard.GetLockerList())

                {

                    //sw.WriteLine(locker.GetColor() + locker.GetPrice(MySqlConnection connection));   // sprint 3:faire distinction entre casier avec porte et casier sans porte

                }



                //sw.WriteLine("Total" + cubBoard.GetPrice(MySqlConnection connection));

            }
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
