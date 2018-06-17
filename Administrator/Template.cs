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
using WindowsFormsApp7;
using Kitbox;

namespace WindowsFormsApp7
{
    public partial class Template : Form
    {

        public Template()
        {
            InitializeComponent();
        }

        //Reconstruction de l'objet cupBoard

        //Recréer accessoires, ensuite locker ensuite extrusion ensuite cupBoard
        //Y-a-t-il une porte? comment savoir --> Ajout BDD
        //Ajout price locker pour aller plus vite
        //attention diff accessoire pour diff locker composant un mm casier : idlock
        //organiser ça ds un datagriedview ensuite sur fichier txt

        public string server;
        public string database;
        public string uid;
        public string password;
        public MySqlConnection connection;
        public MySqlDataAdapter mySqlDataAdapter;

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

        private void Template_Load(object sender, EventArgs e)
        {

        }
    }
}
