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
        double extrusionHeight = Form1.GetCupBoard().GetTotalHeight();

        public Extrusions()
        {
            InitializeComponent();
            
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            string color = extrusionColor.Text;
                      
            Extrusion extrusion = new Extrusion(color, extrusionHeight);
            cupBoard.SetExtrusion(extrusion);
            
            this.Controls.Clear();
            this.Controls.Add(new Recap());
        }

        private void extrusionColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Controls.Clear();
            this.Controls.Add(new Locker());
        }
    }
}
