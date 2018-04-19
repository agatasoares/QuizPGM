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
    public partial class transpot : Form
    {
        public transpot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(B1.Checked)
            {
                B1.ForeColor = Color.Red;
            } 
            else if(B2.Checked)
            {
                B2.ForeColor = Color.Red;
            }
            else if(B3.Checked)
            {
                B3.ForeColor = Color.Green;
            }
        }
    }
}
