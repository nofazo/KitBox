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
    public partial class Locker : System.Windows.Forms.UserControl
    {

        int indexRow;
        DataGridViewRow row = new DataGridViewRow();
        Form1 form = new Form1();
        public static List<Accessory> list = new List<Accessory>();
        CupBoard cupBoard = Form1.GetCupBoard();
        Order order = Form1.GetOrder();

        public Locker()
        {
            InitializeComponent();
        }

        public int HeightGet()          // Hauteur totale du casier
        {
            int height= Convert.ToInt32(comboHeight.Text); 
            return height;
        }

        public int CleatHeightGet()
        {
            return HeightGet() - 4;  // si valeur en cm
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

            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;

         

            HBpanel HBpanell = new HBpanel(ColorGet(), DepthGet(), WidthGet());
            list.Add(HBpanell);

            GDpanel GDpanell = new GDpanel(ColorGet(), DepthGet(), CleatHeightGet());
            list.Add(GDpanell);

            ARpanel ARpanell = new ARpanel(ColorGet(), WidthGet(), CleatHeightGet());
            list.Add(ARpanell);

            ARAVrail ARAVraill = new ARAVrail(WidthGet());   //x2
            list.Add(ARAVraill);

            GDrail GDraill = new GDrail(DepthGet());     //x2      
            list.Add(GDraill);

            Cleat cleatt = new Cleat(CleatHeightGet());           //x4
            list.Add(cleatt);

                      
            // création d'un nouvel objet locker
            Kitbox.Locker locker = new Kitbox.Locker(list, HeightGet(), ColorGet());

            // ajout de mon casier à la liste de casier statique existante dans le Form1
           // Form1.listOfLocker.Add(locker);                                                    //methode qui modifie la listOfLocker si modify
            cupBoard.AddLocker(locker);

            //Comme "list" est une variable static, il faut la réinitialiser pour le prochain locker
            list.Clear();

            dataGridView1["couleur", row].Value = ColorGet();
            dataGridView1["hauteur", row].Value = HeightGet();
            dataGridView1["profondeur", row].Value = DepthGet();
            dataGridView1["largeur", row].Value = WidthGet();


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
            if (order.GetState() == "InProgress")
            {
                foreach  ( Kitbox.Locker locker  in  Form1.GetListofLocker() )
                {
                    //remplir le datagridview avec les valeurs des objects existants

                    int row = 0;
                    dataGridView1.Rows.Add();
                    row = dataGridView1.Rows.Count - 2;
                    dataGridView1["couleur", row].Value = locker.GetColor();
                    dataGridView1["hauteur", row].Value = locker.GetLockerHeight();
                    dataGridView1["profondeur", row].Value = cupBoard.GetDepth();
                    dataGridView1["largeur", row].Value =cupBoard.GetWidth();

                }
            
            
            }

        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`lockers` (`FkOrder`, `color`,`height`, `depth`, `width`) VALUES ('"+order.GetidOrder()+ " ', '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "');", form.connection);
                   
                    cmd.ExecuteNonQuery();

                   
                }

                dataGridView1.Rows.Clear();

                //close connection
                form.CloseConnection();
            }
            if (form.OpenConnection() == true)
            {
                Order order = Form1.GetOrder();
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
