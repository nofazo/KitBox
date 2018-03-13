using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class UserControl4 : UserControl
    {
     
        public UserControl4()
        {
            InitializeComponent();
        }

        private void AddLocker_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControl4());
        }

        private void comboLongeur_SelectedIndexChanged(object sender, EventArgs e)
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
          

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Form2 f2 = new Form2();
                // f2.UserControl4 = this; // Allow Form2 to access Form1 public members
                f2.ShowDialog();
            }
        }

    }
}
