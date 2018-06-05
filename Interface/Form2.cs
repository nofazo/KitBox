using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kitbox;

namespace Interface
{
    public partial class Form2 : Form
    {
        // Comme je ne peux pas créer d'objet dans le 'if' d'en bas, je les crée ici et je n'en prendrai qu'un seul des deux
        GlassDoor glassDoor = new GlassDoor();
        NormalDoor normalDoor = new NormalDoor("");

        public Form2()
        {
            InitializeComponent();
        }

        public string GetDoor()
        {
            if (woodButton.Checked == true)
                return "wood";
            else
                return "glass";
        }

        public string GetColorDoor()
        {
            if (GetDoor() == "wood")
                return comboBox1.Text;
            else
                return "glass";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void woodButton_CheckedChanged(object sender, EventArgs e)
        {
            if (woodButton.Checked == true)
            {
                textBox2.Visible = true;
                pictureBox1.Visible = false;
            }

            else
            {
                textBox2.Visible = false;
                pictureBox1.Visible = true;
            }
        }

        private void DoorValid_Click(object sender, EventArgs e)
        {
            if (GetDoor() == "glass")
                Locker.list.Add(glassDoor);       // Locker référencie à Locker.cs et non le type Locker qui est référencié par KitBox.Locker
            else
                normalDoor.SetColor(GetColorDoor());
                Locker.list.Add(normalDoor);
                

            if (woodButton.Checked == true )
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Select a value please!");
                }

                else
                    this.Close();
            }

            else 
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}