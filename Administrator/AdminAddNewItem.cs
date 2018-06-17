using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp7
{
    public partial class AdminAddNewITem : UserControl

    {
        TablesDisplay tablesDisplay = new TablesDisplay();

        public AdminAddNewITem()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tablesDisplay.OpenConnection() == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `kitboxdb2.0`.`parts` (`Ref`, `Idpart`, `Dimensions`, `height`, `depth`, `width`, `color`, `InStock`, `StockMin`, `Price`, `PartForLocker`) VALUES ('"+dataGridView1.Rows[i].Cells[0].Value+ "', '" + dataGridView1.Rows[i].Cells[1].Value + "', '" + dataGridView1.Rows[i].Cells[2].Value + "', '" + dataGridView1.Rows[i].Cells[3].Value + "', '" + dataGridView1.Rows[i].Cells[4].Value + "', '" + dataGridView1.Rows[i].Cells[5].Value + "', '" + dataGridView1.Rows[i].Cells[6].Value + "', '" + dataGridView1.Rows[i].Cells[7].Value + "', '" + dataGridView1.Rows[i].Cells[8].Value + "', '" + dataGridView1.Rows[i].Cells[9].Value + "', '" + dataGridView1.Rows[i].Cells[10].Value + "');", tablesDisplay.connection);
                    
                    cmd.ExecuteNonQuery();
                }

                dataGridView1.Rows.Clear();
                //close connection
                tablesDisplay.CloseConnection();
            }

        }
        private void AdminAddNewITem_Load(object sender, EventArgs e)
        {
            tablesDisplay.server = "localhost";
            tablesDisplay.database = "kitboxdb2.0";
            tablesDisplay.uid = "root";
            tablesDisplay.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + tablesDisplay.server + ";" + "DATABASE=" + tablesDisplay.database + ";" + "UID=" + tablesDisplay.uid + ";" + "PASSWORD=" + tablesDisplay.password + ";";

            tablesDisplay.connection = new MySqlConnection(connectionString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int row = 0;
            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;
            dataGridView1["REF", row].Value = textBox12.Text;
            dataGridView1["IdPart", row].Value = textBox13.Text;
            dataGridView1["Dimensions", row].Value = textBox14.Text;
            dataGridView1["Height", row].Value = textBox15.Text;
            dataGridView1["Depth", row].Value = textBox16.Text;
            dataGridView1["Width", row].Value = textBox17.Text;
            dataGridView1["Color", row].Value = textBox18.Text;
            dataGridView1["Instock", row].Value = textBox19.Text;
            dataGridView1["StockMin", row].Value = textBox20.Text;
            dataGridView1["Price", row].Value = textBox21.Text;
            dataGridView1["PartForLocker", row].Value = textBox22.Text;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AdminMenu());
        }
    }
}
