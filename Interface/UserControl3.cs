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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        public int WidthGet()
        {
            int width= Convert.ToInt32(comboWidth.Text);
            return width;
        }

        public int DepthGet()
        {
            int deep = Convert.ToInt32(comboDepth.Text);
            return deep;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControl4(WidthGet(), DepthGet()));
        }

        private void comboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboDepth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
