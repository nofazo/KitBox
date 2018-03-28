﻿using System;
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
    public partial class SpecAllLock : System.Windows.Forms.UserControl
    {
        public SpecAllLock()
        {
            InitializeComponent();
        }

        public int WidthGet()
        {
                int width = Convert.ToInt32(comboWidth.Text);
                return width;
        }

        public int DepthGet()
        {
            int deep = Convert.ToInt32(comboDepth.Text);
            return deep;
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            if (comboWidth.Text == "" || comboDepth.Text == "")
            {
                MessageBox.Show("Select a value please!");
            }
            else
            {
                this.Controls.Clear();
                this.Controls.Add(new Locker(WidthGet(), DepthGet()));
            }

            Extrusion extrusion = new Extrusion("", 0);
            List<Kitbox.Locker> lockerList = new List<Kitbox.Locker>();

            CupBoard cupBoard = new CupBoard(WidthGet(), DepthGet(), lockerList, extrusion);     
        }


        //public CupBoard GetCupBoard()
        //{
            
        //}

        private void comboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WidthGet() > 62)
            {
                textBox1.Visible = true;
            }
            else
                textBox1.Visible = false;

        }

        private void comboDepth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}