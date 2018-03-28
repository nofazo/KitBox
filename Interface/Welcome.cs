using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace Interface
{
    public partial class Welcome : System.Windows.Forms.UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new SpecAllLock());
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            Login Admin = new Login();
            Admin.ShowDialog();
            
            
            

        }
    }
}
