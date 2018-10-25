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
    public partial class armamento : Form
    {
        public armamento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.ForeColor = Color.Red;
            }
            if (radioButton2.Checked)
            {
                radioButton2.ForeColor = Color.Green;
            }
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Red;
            }
            if (radioButton4.Checked)
            {
                radioButton4.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            armamento2 armamento2 = new armamento2();
            armamento2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
