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
using static Kitbox.Accessory;

namespace Interface
{
    public partial class Locker : System.Windows.Forms.UserControl
    {

        int indexRow;
        DataGridViewRow row = new DataGridViewRow();
        Form1 form = new Form1();
        public static List<String> list = new List<String>();  // just for door or other access wich use other form (like door)
        CupBoard cupBoard = Form1.GetCupBoard();

        Order order = Form1.GetOrder();


        public Locker()
        {
            InitializeComponent();
        }

        public int HeightGet()          // Hauteur totale du casier
        {
            int height = Convert.ToInt32(comboHeight.Text);
            return height;
        }

        public int LockerHeightGet()
        {
            return HeightGet() + 4;  // si valeur en cm
        }

        public string ColorGet()
        {
            string color = ColorBox.Text;
            return color;

        }

        public double DepthGet()
        {
            return cupBoard.GetDepth();
        }

        public double WidthGet()
        {
            return cupBoard.GetWidth();
        }




        private void AddLocker_Click(object sender, EventArgs e)
        {
            if (ColorBox.Text == "" || comboHeight.Text == "")
            {
                MessageBox.Show("Select a value please!");
            }

            if (cupBoard.GetLockerList().Count() == 7)
            {
                MessageBox.Show("You have reached the maximum number of lockers");
            }

            else
            {

            }

            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;

            List<Accessory> accList = new List<Accessory>();

            HBpanel HBpanell = new HBpanel(ColorGet(), DepthGet(), WidthGet());
            accList.Add(HBpanell);

            GDpanel GDpanell = new GDpanel(ColorGet(), DepthGet(), HeightGet());
            accList.Add(GDpanell);

            ARpanel ARpanell = new ARpanel(ColorGet(), WidthGet(), HeightGet());
            accList.Add(ARpanell);

            ARrail ARraill = new ARrail(WidthGet());
            accList.Add(ARraill);

            AVrail AVraill = new AVrail(WidthGet());
            accList.Add(AVraill);

            GDrail GDraill = new GDrail(DepthGet());     //x2      
            accList.Add(GDraill);

            Cleat cleat = new Cleat(HeightGet());           //x4
            accList.Add(cleat);

            //Add door (if there is one)
            if (list.Count() != 0)
            {
                if (list[0] == "wood")
                {
                    NormalDoor door = new NormalDoor(HeightGet(), WidthGet(), list[1]);
                    accList.Add(door);
                }

                if (list[0] == "glass")
                {
                    GlassDoor door = new GlassDoor(HeightGet(), WidthGet());
                }
            }


            // création d'un nouvel objet locker
            Kitbox.Locker locker = new Kitbox.Locker(accList, LockerHeightGet(), ColorGet());

            // ajout de mon casier à la liste de casier statique existante dans le Form1
            // Form1.listOfLocker.Add(locker);                                                    //methode qui modifie la listOfLocker si modify
            cupBoard.AddLocker(locker);

            //Vérifier si un suplément devras être payé
            double extrusionHeight = cupBoard.GetTotalHeight();

            if (cupBoard.GetExtrusion().IsCut(extrusionHeight))
                textBox1.Visible = true;

            else
                textBox1.Visible = false;


            // on ajoute dans le datagrid les infos
            dataGridView1["ColorLocker", row].Value = ColorGet();
            dataGridView1["HeightLocker", row].Value = HeightGet();
            //Si la porte est en bois
            if (list.Count() != 0)
            {
                dataGridView1["DoorType", row].Value = list[0];

                if (list[0] == "wood")
                {
                    dataGridView1["ColorDoor", row].Value = list[1];
                }

            }

            // verification availability

            form.OpenConnection();

            foreach (Accessory accessory in locker.GetAccessoryList())
            {
                double instock = accessory.GetInstock(form.connection);

                if (instock < 1)
                {
                    MessageBox.Show("Some items are sold out , a 7 days delay is neccessary to get them. ");
                    dataGridView1["Disponibility", row].Value = "Not Available";
                    break;
                }
                else
                {
                    dataGridView1["Disponibility", row].Value = "Available";                                        
                }

            }
            form.CloseConnection();
            
            
            

            //Comme "list" est une variable static, il faut la réinitialiser pour le prochain door
            list.Clear();
        }
    

        private void comboHeight_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ColorBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          //no
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();               
            } 
        }

        public void UserControl4_Load(object sender, EventArgs e)
        {

        }
    
 
        private void UserControl4_Load_1(object sender, EventArgs e)

        {
            int idOrder = order.GetidOrder();
           
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";

            form.connection = new MySqlConnection(connectionString);


            if (WidthGet() < 62)
            {
                pictureBox1.Visible = false;
            }
            
            Update.Hide();

            //Si on est en previous
            if (order.GetState() == "InProgress" || order.GetState() == "Completed")
            {
                foreach (Kitbox.Locker locker in Form1.GetListofLocker())
                {
                    //remplir le datagridview avec les valeurs des objects existants

                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 2;
                    dataGridView1["ColorLocker", row].Value = locker.GetColor();
                    dataGridView1["HeightLocker", row].Value = locker.GetLockerHeight()-4;
                    foreach (Accessory accessory in locker.GetAccessoryList())
                    {
                        if (accessory.GetAccessType() == "normalDoor")
                        {
                            dataGridView1["DoorType", row].Value = "Wood";
                            NormalDoor accessory2 = (NormalDoor)accessory;
                            dataGridView1["ColorDoor", row].Value = accessory2.GetColor();
                        }
                        if (accessory.GetAccessType() == "glassDoor")
                        {
                            dataGridView1["DoorType", row].Value = "Glass";

                        }


                    }
                    //availability gestion in previous mode
                    form.OpenConnection();
                    foreach (Accessory accessory in locker.GetAccessoryList())
                    {
                        double instock = accessory.GetInstock(form.connection);

                        if (instock < 1)
                        {
                            
                            dataGridView1["Disponibility", row].Value = "Not Available";
                            break;
                        }
                        else
                        {
                            dataGridView1["Disponibility", row].Value = "Available";
                        }

                    }
                    form.CloseConnection();


                }
            }

            }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                int idOrder = order.GetidOrder();
                //update in database if previous mode.
                if (order.GetState() == "InProgress")
                {
                    MySqlCommand cmd2 = new MySqlCommand("Delete FROM `kitboxdb2.0`.`lockers` WHERE FkOrder ='" + idOrder + "'", form.connection);
                    cmd2.ExecuteNonQuery();
                }

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`lockers` (`FkOrder`, `color`,`height`, `depth`, `width`) VALUES ('"+order.GetidOrder()+ " ', '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + DepthGet() + "', '" + WidthGet() + "');", form.connection);
                   
                    cmd.ExecuteNonQuery();

                   
                }

                dataGridView1.Rows.Clear();

                //close connection
                form.CloseConnection();
            }
            if (form.OpenConnection() == true)
            {
                int idOrder = order.GetidOrder();

                order.SetState("InProgress");
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`orders` SET State='InProgress' WHERE idOrder ='" + idOrder + "'", form.connection);

                cmd.ExecuteNonQuery();

            }
            this.Controls.Clear();
            this.Controls.Add(new Extrusions());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            AddLocker.Hide();
            Finish.Hide();
            
            Update.Show();
            radioButton1.Hide();
            radioButton2.Hide();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            comboHeight.Text = row.Cells[1].Value.ToString();
            ColorBox.Text = row.Cells[0].Value.ToString();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            //Update in datagrid
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[1].Value = comboHeight.Text;
            newDataRow.Cells[0].Value = ColorBox.Text;
            
            AddLocker.Show();
            Finish.Show();
            Update.Hide();
            radioButton1.Show();
            radioButton2.Show();

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new SpecAllLock());
        }
    }
}
