﻿using System;
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