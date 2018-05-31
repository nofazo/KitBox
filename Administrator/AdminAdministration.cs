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
    public partial class AdminAdministration : UserControl
    {
        TablesDisplay tablesDisplay = new TablesDisplay();

        public AdminAdministration()
        {
            InitializeComponent();
        }

        int indexRow;
        DataGridViewRow row = new DataGridViewRow();

        private void AdminAddingExistingItem_Load(object sender, EventArgs e)
        {
            tablesDisplay.server = "localhost";
            tablesDisplay.database = "kitboxdb2.0";
            tablesDisplay.uid = "root";
            tablesDisplay.password = "Senbonzakura1493";
            string connectionString;

            connectionString = "SERVER=" + tablesDisplay.server + ";" + "DATABASE=" + tablesDisplay.database + ";" + "UID=" + tablesDisplay.uid + ";" + "PASSWORD=" + tablesDisplay.password + ";";

            tablesDisplay.connection = new MySqlConnection(connectionString);

            if (tablesDisplay.OpenConnection() == true)
            {
                tablesDisplay.mySqlDataAdapter = new MySqlDataAdapter("select * from parts", tablesDisplay.connection);
                DataSet DS = new DataSet();
                tablesDisplay.mySqlDataAdapter.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];

                //close connection
                tablesDisplay.CloseConnection();


            }
           

            groupBox1.Hide();
        }

        private void FindIt_Click(object sender, EventArgs e)
        {
            int times = 0;

            if (dataGridView1 != null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null && cell.Value.Equals(textBox1.Text.ToString()))
                        {
                            times += 1;
                            cell.Style.BackColor = Color.Yellow;
                        }

                    }

                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            textBoxRef.Text = row.Cells[0].Value.ToString();
            textBoxId.Text = row.Cells[1].Value.ToString();

            textBoxDim.Text = row.Cells[2].Value.ToString();
            textBoxHeight.Text = row.Cells[3].Value.ToString();
            textBoxDepth.Text = row.Cells[4].Value.ToString();
            textBoxWidth.Text = row.Cells[5].Value.ToString();
            textBoxColor.Text = row.Cells[6].Value.ToString();
            textBoxIStock.Text = row.Cells[7].Value.ToString();
            textBoxStockMin.Text = row.Cells[8].Value.ToString();
            textBoxPrice.Text = row.Cells[9].Value.ToString();
            textBoxPlocker.Text = row.Cells[10].Value.ToString();
        }

        private void Modify_Click_1(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {            
            //update in the datagridview
            DataGridViewRow newDataRow = dataGridView1.Rows[indexRow];
            newDataRow.Cells[0].Value = textBoxRef.Text;
            newDataRow.Cells[1].Value = textBoxId.Text;
            newDataRow.Cells[2].Value = textBoxDim.Text;
            newDataRow.Cells[3].Value = textBoxHeight.Text;
            newDataRow.Cells[4].Value = textBoxDepth.Text;
            newDataRow.Cells[5].Value = textBoxWidth.Text;
            newDataRow.Cells[6].Value = textBoxColor.Text;
            newDataRow.Cells[7].Value = textBoxIStock.Text;
            newDataRow.Cells[8].Value = textBoxStockMin.Text;
            newDataRow.Cells[9].Value = textBoxPrice.Text;
            newDataRow.Cells[10].Value = textBoxPlocker.Text;



            //Update in database
            if (tablesDisplay.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE `kitboxdb2.0`.`parts` SET `Ref`='" + newDataRow.Cells[0].Value + "', `Dimensions`='" + newDataRow.Cells[2].Value + "', `height`='" + newDataRow.Cells[3].Value + "', `depth`='" + newDataRow.Cells[4].Value + "', `width`='" + newDataRow.Cells[5].Value + "', `color`='" + newDataRow.Cells[6].Value + "', `InStock`='" + newDataRow.Cells[7].Value + "', `StockMin`='" + newDataRow.Cells[8].Value + "', `Price`='" + newDataRow.Cells[9].Value + "', `PartForLocker`='" + newDataRow.Cells[10].Value + "' WHERE `Idpart`='" + newDataRow.Cells[1].Value + "';", tablesDisplay.connection);
                cmd.ExecuteNonQuery();                
                tablesDisplay.CloseConnection();
            }

            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (tablesDisplay.OpenConnection() == true)
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                MySqlCommand cmd = new MySqlCommand("DELETE FROM `kitboxdb2.0`.`parts` WHERE `Idpart`='" + row.Cells[1].Value + "';", tablesDisplay.connection);
                cmd.ExecuteNonQuery();
                dataGridView1.Rows.RemoveAt(rowIndex);                 
                tablesDisplay.CloseConnection();
                
            }
          

        }

        private void textBoxRef_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDim_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
