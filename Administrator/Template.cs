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
     

        //Retourne les id des lockers spécifiques à une commande
        public List<int> GetLockersID (MySqlConnection connection, int FkOrder)
        {
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT idLocker FROM `kitboxdb2.0`.`lockers` WHERE FkOrder='" + Convert.ToString(FkOrder) + "'", connection);

            reader = command.ExecuteReader();

            List<int> IDList = new List<int>();
            int lockersID = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lockersID = reader.GetInt32(0);
                    IDList.Add(lockersID);
                }
            }
            else
            {
                MessageBox.Show("this order is empty");
            }

            reader.Close();

            return IDList;
        }

        public Dictionary<string, string> GetLockerAttribute (MySqlConnection connection, int FkOrder, int idLocker)
        {
            Dictionary<string, string> lockerAttribute = new Dictionary<string, string>();
            MySqlDataReader reader;
            MySqlCommand command = new MySqlCommand("SELECT height, width, Depth, color FROM `kitboxdb2.0`.`lockers` WHERE FkOrder='" + Convert.ToString(FkOrder) + "'AND idLocker='" + Convert.ToString(idLocker) + "'", connection);

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lockerAttribute.Add("height", reader.GetString(0));
                    lockerAttribute.Add("width", reader.GetString(1));
                    lockerAttribute.Add("depth", reader.GetString(2));
                    lockerAttribute.Add("color", reader.GetString(3));
                }
            }
            else
            {
                MessageBox.Show("there is no cupboard for this order");
            }

            reader.Close();

            return lockerAttribute;
        }

        public List<Accessory> GetAccessoryList(Dictionary<string, string> lockerAttribute)
        {
            List<Accessory> accessList = new List<Accessory>();
            
            string color = lockerAttribute["color"];
            double height = Convert.ToDouble(lockerAttribute["height"]);
            double width = Convert.ToDouble(lockerAttribute["width"]);
            double depth = Convert.ToDouble(lockerAttribute["depth"]);

            Accessory.HBpanel HBpanel = new Accessory.HBpanel(color, depth, width);
            accessList.Add(HBpanel);

            Accessory.GDpanel GDpanel = new Accessory.GDpanel(color, depth, height);
            accessList.Add(GDpanel);

            Accessory.ARpanel ARpanel = new Accessory.ARpanel(color, width, height);
            accessList.Add(ARpanel);

            Accessory.ARrail ARraill = new Accessory.ARrail(width);
            accessList.Add(ARraill);

            Accessory.AVrail AVraill = new Accessory.AVrail(width);
            accessList.Add(AVraill);

            Accessory.GDrail GDraill = new Accessory.GDrail(depth);     
            accessList.Add(GDraill);

            Accessory.Cleat cleat = new Accessory.Cleat(height);           
            accessList.Add(cleat);

            //if there is a door
            if (lockerAttribute.ContainsKey("door"))
            {
                if (lockerAttribute["door"] == "glass")
                {
                    Accessory.GlassDoor glassDoor = new Accessory.GlassDoor(height, width);
                    accessList.Add(glassDoor);
                }

                else
                {
                    Accessory.NormalDoor normalDoor = new Accessory.NormalDoor(height, width, lockerAttribute["door"]);
                    accessList.Add(normalDoor);
                }
            }

            return accessList;
        }

        public List<Locker> GetLockerList(MySqlConnection connection, int FkOrder)
        {
            List<int> idLockers = GetLockersID(connection, FkOrder);
            List<Locker> lockerList = new List<Locker>();

            foreach (int idLocker in idLockers)
            {               
                Dictionary<string, string> lockerAttribute = GetLockerAttribute(connection, FkOrder, idLocker);
                List<Accessory> accessList = GetAccessoryList(lockerAttribute);
                double height = (Convert.ToDouble(lockerAttribute["height"]) + 4);
                string color = lockerAttribute["color"];

                Locker locker = new Locker(accessList, height, color);  // height + 4?  ou -
                lockerList.Add(locker);

            }  

            return lockerList;
        }

        public CupBoard GetCupBoard(MySqlConnection connection, int FkOrder)
        {
            List<Locker> lockerList = GetLockerList(connection, FkOrder);
            List<int> idLockers = GetLockersID(connection, FkOrder);
            int idLocker = idLockers[0];

            Dictionary <string, string> lockerAttribute = GetLockerAttribute(connection, FkOrder, idLocker);
            
            string color = lockerAttribute["color"];
            double width = Convert.ToDouble(lockerAttribute["width"]);
            double depth = Convert.ToDouble(lockerAttribute["depth"]);

            Extrusion extrusion = new Extrusion(color, 0);                                      //Attention la couleur n'est pas la bonne !
            CupBoard cupBoard = new CupBoard(width, depth, lockerList, extrusion);
            double extrusionHeight = cupBoard.GetTotalHeight();
            cupBoard.GetExtrusion().SetHeight(extrusionHeight);

            return cupBoard;          
        }

        
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
