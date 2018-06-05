using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Kitbox;

namespace Interface
{
    public partial class Form1 : Form
    {

        public string server;
        public string database;
        public string uid;
        public string password;
        public MySqlConnection connection;
        public MySqlDataAdapter mySqlDataAdapter;

        private static Extrusion extrusion = new Extrusion("", 0);
        private static List<Kitbox.Locker> listOfLocker = new List<Kitbox.Locker>();  
        private static CupBoard cupBoard = new CupBoard(0,0, listOfLocker, extrusion);

        
        static public CupBoard GetCupBoard()
        {
            return cupBoard;
        }


        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Controls.Add(new Welcome());
                    
        }
    }
}
