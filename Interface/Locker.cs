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


        public Locker()
        {
            InitializeComponent();
        }

        public int HeightGet()
        {
            int height= Convert.ToInt32(comboHeight.Text); 
            return height;
        }

        public int CleatHeightGet()
        {
            return HeightGet() - 4;
        }

        public string ColorGet()
        {
            string color = ColorBox.Text;
            return color;

        }

        public int DepthGet()
        {
            return Form1.cupBoard.depth;
        }

        public int WidthGet()
        {
            return Form1.cupBoard.width;
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

         
           
            List<Accessory> list = new List<Accessory>();

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

            
            // je crée un objet par ligne avec sa liste d'accessoire associée.
            Kitbox.Locker locker = new Kitbox.Locker(list, HeightGet(), ColorGet());


            // ajout de mon casier à la liste de casier statique existante dans le Form1
            Form1.listOfLocker.Add(locker);

            dataGridView1["couleur", row].Value = ColorGet();
            dataGridView1["hauteur", row].Value = HeightGet();
            dataGridView1["profondeur", row].Value = WidthGet();
            dataGridView1["largeur", row].Value = DepthGet();


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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //yes
            if (radioButton2.Checked)
            {
                Form2 f2 = new Form2();
                // f2.UserControl4 = this; // Allow Form2 to access Form1 public members
                f2.ShowDialog();
            }
        }

        public void UserControl4_Load(object sender, EventArgs e)
        {

        }
    
 
        private void UserControl4_Load_1(object sender, EventArgs e)
        {
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
            
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            if (form.OpenConnection() == true)
            {
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`lockers` (`FkOrder`, `color`,`height`, `depth`, `width`) VALUES (' 1 ', '" + dataGridView1.Rows[i].Cells[0].Value + "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "');", form.connection);
                   
                    cmd.ExecuteNonQuery();
                                      
                }

                dataGridView1.Rows.Clear();

                //close connection
                form.CloseConnection();
            }
            this.Controls.Clear();
            this.Controls.Add(new Extrusions());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            AddLocker.Hide();
            Finish.Hide();
            listBox1.Hide();
            
            Update.Show();
            radioButton1.Hide();
            radioButton2.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            listBox1.Show();
            Update.Hide();
            radioButton1.Show();
            radioButton2.Show();



        }
    }
}
