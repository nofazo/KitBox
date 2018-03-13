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

    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(new UserControl4());
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            List<Accessory> list = new List<Accessory>();

            double hauteur = Convert.ToDouble(comboLargeur);

            double hauteurTasseau = hauteur - 4; // en cm

            HBpanel HBpanell = new HBpanel(couleur, profondeur, largeur);
            list.Add(HBpanell);

            GDpanel GDpanell = new GDpanel(couleur, profondeur, hauteurTasseau);
            list.Add(GDpanell);

            ARpanel ARpanell = new ARpanel(couleur, largeur, hauteurTasseau);
            list.Add(ARpanell);

            ARAVrail ARAVraill = new ARAVrail(largeur);   //x2
            list.Add(ARAVraill);

            GDrail GDraill = new GDrail(profondeur);     //x2
            list.Add(GDraill);

            Cleat cleatt = new Cleat(hauteurTasseau);           //x4
            list.Add(cleatt);
        }
    }
}
