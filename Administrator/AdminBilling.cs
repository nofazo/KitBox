using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class AdminBilling : UserControl
    {
        public string CmdID;
        public AdminBilling()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            

        }

        private void comboBoxCmdID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmdID = comboBoxCmdID.Text;
        }
    }
}
