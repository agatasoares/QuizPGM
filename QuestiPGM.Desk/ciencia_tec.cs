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
    public partial class ciencia_tec : Form
    {
        public ciencia_tec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alternativa_1.Checked)
            {
                alternativa_1.ForeColor = Color.Red;
            }
            if (alternativa_2.Checked)
            {
                alternativa_2.ForeColor = Color.Green;
            }
            if (alternativa_3.Checked)
            {
                alternativa_3.ForeColor = Color.Red;
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
