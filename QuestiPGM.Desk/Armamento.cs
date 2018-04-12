using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestiPGM.Desk
{
    public partial class Armamento : Form
    {
        public Armamento()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (p01op01.Checked)
            {
                p01op01.ForeColor = Color.Red;
            }

            else if (p01op02.Checked)
            {
                
                p01op02.ForeColor = Color.Green;
            }

            else if (p01op03.Checked) 
           
            {
                p01op03.ForeColor = Color.Red;
            }

            else if (p01op04.Checked)
            {
                p01op04.ForeColor = Color.Red;
            }


        }
            
}
}
