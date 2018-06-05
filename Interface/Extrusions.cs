using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitbox;

namespace Interface
{
    public partial class Extrusions : System.Windows.Forms.UserControl
    {
        CupBoard cupBoard = Form1.GetCupBoard();

        public Extrusions()
        {
            InitializeComponent();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            string color = extrusionColor.Text;
            double extrusionHeight = cupBoard.GetTotalHeight();

            
            Extrusion extrusion = new Extrusion(color, extrusionHeight);
            cupBoard.SetExtrusion(extrusion);


            //parcours de la bdd pour prendre leur hauteur 
            //les additionner 
            //choisir la bonne cornière (d'abord non découpée et ensuite découpée)

            this.Controls.Clear();
            this.Controls.Add(new Recap());
        }

        private void extrusionColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
