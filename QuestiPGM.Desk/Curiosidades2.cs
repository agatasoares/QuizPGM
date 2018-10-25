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
    public partial class Curiosidades2 : Form
    {
        public Curiosidades2()
        {
            InitializeComponent();
        }

        private void check2_Click(object sender, EventArgs e)
        {
            if (alt3.Checked)
            {
                alt3.ForeColor = Color.Red;
            }
            if (alt4.Checked)
            {
                alt4.ForeColor = Color.Green;
            }
            if (alt5.Checked)
            {
                alt5.ForeColor = Color.Red;
            }
        }

        private void finalizar_Click(object sender, EventArgs e)
        { 
                Application.Exit(); // encerrar
        }
    }
}
