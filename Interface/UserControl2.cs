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
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControl3());
        }
    }
}
