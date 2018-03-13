using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void woodButton_CheckedChanged(object sender, EventArgs e)
        {
            if (woodButton.Checked == true)
            {
                textBox2.Visible = true;
            }
            else
            {
                textBox2.Visible = false;

            }
        }

        private void DoorValid_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
