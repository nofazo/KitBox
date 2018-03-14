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
        int width;
        int deep;
        string color;
        double hauteur;
        double hauteurTasseau;

        public UserControl4(int width,int deep)
        {
            InitializeComponent();
            this.width = width;
            this.deep = deep;
            string color = ColorBox.Text;
            double hauteur = Convert.ToDouble(comboHeight.SelectedValue);
            double hauteurTasseau = hauteur - 4; // en cm
            this.color = color;
            this.hauteur = hauteur;
            this.hauteurTasseau = hauteurTasseau;


        }

        private void AddLocker_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Controls.Add(new UserControl4(width , deep));
        }

        private void comboHeight_SelectedIndexChanged(object sender, EventArgs e)
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
        public void UserControl4_Load(object sender, EventArgs e)

        {


            List<Accessory> list = new List<Accessory>();
            HBpanel HBpanell = new HBpanel(color,deep,width);

            list.Add(HBpanell);



            GDpanel GDpanell = new GDpanel(color, deep, hauteurTasseau);

            list.Add(GDpanell);



            ARpanel ARpanell = new ARpanel(color, width, hauteurTasseau);

            list.Add(ARpanell);



            ARAVrail ARAVraill = new ARAVrail(width);   //x2

            list.Add(ARAVraill);



            GDrail GDraill = new GDrail(deep);     //x2

            list.Add(GDraill);



            Cleat cleatt = new Cleat(hauteurTasseau);           //x4

            list.Add(cleatt);

        }

    
 
        private void UserControl4_Load_1(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(this.deep) + " coucou "+ Convert.ToString(this.width); 
        }
    }
}
