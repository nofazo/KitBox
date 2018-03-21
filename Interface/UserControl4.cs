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
    public partial class UserControl4 : System.Windows.Forms.UserControl
    {
        int width;
        int deep;
        string color;
        double height;
        double cleatHeight;

        public UserControl4(int width,int deep)
        {
            InitializeComponent();
            this.width = width;
            this.deep = deep;
            string color = ColorBox.Text;

            double height = Convert.ToDouble(comboHeight.SelectedValue);
            double cleatHeight = height - 4; // en cm
            this.color = color;
            this.height = height;
            this.cleatHeight = cleatHeight;
        }

        private void AddLocker_Click(object sender, EventArgs e)
        {
            if (ColorBox.Text == "" || comboHeight.Text == "")
            {
                MessageBox.Show("Select a value please!");
            }
            else
            {
                this.Controls.Clear();
                this.Controls.Add(new UserControl4(width, deep));
            }

            List<Accessory> list = new List<Accessory>();

            HBpanel HBpanell = new HBpanel(color, deep, width);
            list.Add(HBpanell);

            GDpanel GDpanell = new GDpanel(color, deep, cleatHeight);
            list.Add(GDpanell);

            ARpanel ARpanell = new ARpanel(color, width, cleatHeight);
            list.Add(ARpanell);

            ARAVrail ARAVraill = new ARAVrail(width);   //x2
            list.Add(ARAVraill);

            GDrail GDraill = new GDrail(deep);     //x2      
            list.Add(GDraill);

            Cleat cleatt = new Cleat(cleatHeight);           //x4
            list.Add(cleatt);

            Locker locker = new Locker(list, height, color);         // ouu Casier.AddAccessory(cleatt);

            //Form1 form = new Form1();
            //form.OpenConnection();

            Form1 form = new Form1();
            form.server = "localhost";
            form.database = "kitboxdb";
            form.uid = "root";
            form.password = "Houda3ba";
            string connectionString;
            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";
            form.connection = new MySqlConnection(connectionString);
            //form.OpenConnection();

            if (form.OpenConnection() == true)
            {
                // string MySQLCmd1 = "qui va chercher le bon id";
                string MySQLCmd = " INSERT INTO locker(height, door, color, price) VALUES("+"'78', '1', 'white', '1'"+")";
                MySqlCommand MySQLCommand = new MySqlCommand(MySQLCmd, form.connection);
                MySQLCommand.ExecuteNonQuery();


                

                
                
            }
            
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
            textBox2.Text = "Profondeur : " + Convert.ToString(this.deep) + " cm \nLargeur : " + Convert.ToString(this.width) +" cm" ;

            if (width < 62)
            {
                pictureBox1.Visible = false;
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControl6());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
