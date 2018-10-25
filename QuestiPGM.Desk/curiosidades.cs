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
    public partial class curiosidades : Form
    {
        public curiosidades()
        {
            InitializeComponent();
        }

        private void curiosidades_Load(object sender, EventArgs e)
        {
           
        }

        private void proximo2_Click(object sender, EventArgs e)
        {
            Curiosidades2 Curiosidades2 = new Curiosidades2();
            Curiosidades2.ShowDialog();
        }

        private void check2_Click(object sender, EventArgs e)
        {
           
        }

        private void check2_Click_1(object sender, EventArgs e)
        {
            if (alt1.Checked)
            {
                alt1.ForeColor = Color.Green;
            }
            if (alt2.Checked)
            {
                alt2.ForeColor = Color.Red;
            }
        }
    }
}
