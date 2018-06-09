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
    public partial class SpecAllLock : System.Windows.Forms.UserControl
    {
        Form1 form = new Form1();
        public SpecAllLock()
        {
            InitializeComponent();
        }

        public int WidthGet()
        {
                int width = Convert.ToInt32(comboWidth.Text);
                return width;
        }

        public int DepthGet()
        {
            int deep = Convert.ToInt32(comboDepth.Text);
            return deep;
        }
        

        protected void button1_Click(object sender, EventArgs e)
        {
            if (comboWidth.Text == "" || comboDepth.Text == "")
            {
                MessageBox.Show("Select a value please!");
            }
            else
            {
                CupBoard cupBoard = Form1.GetCupBoard();
                cupBoard.SetWidth(WidthGet());
                cupBoard.SetDepth(DepthGet());

                

            }
            
            this.Controls.Clear();
            this.Controls.Add(new Locker());
        }

       
        private void comboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WidthGet() > 62)
            {
                textBox1.Visible = true;
            }
            else
                textBox1.Visible = false;

        }

        private void comboDepth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new Welcome());
        }

        private void SpecAllLock_Load(object sender, EventArgs e)
        {
            form.server = "localhost";
            form.database = "kitboxdb2.0";
            form.uid = "root";
            form.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + form.server + ";" + "DATABASE=" + form.database + ";" + "UID=" + form.uid + ";" + "PASSWORD=" + form.password + ";";

            form.connection = new MySqlConnection(connectionString);
        }
    }
}
