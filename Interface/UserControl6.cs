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
    public partial class UserControl6 : System.Windows.Forms.UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            // calcul de la hauteur total
            //parcours de la bdd pour prendre leur hauteur 
            //les additionner 
            //choisir la bonne cornière (d'abord non découpée et ensuite découpée)
            this.Controls.Clear();
            this.Controls.Add(new UserControl5());
        }

        private void extrusionColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
