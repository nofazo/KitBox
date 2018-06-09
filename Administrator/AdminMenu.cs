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
    public partial class AdminMenu : UserControl
    {
        
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AdminBilling());

        }

        private void AdminAddITem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new AdminAdministration());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
                        
        

        private void AdminAddNewItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Hide();
            TablesDisplay formTable = new TablesDisplay();
            formTable.Show();
            formTable.Controls.Add(new AdminAddNewITem());
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
