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
    public partial class categoriapa : Form
    {
        public categoriapa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void alternativa_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alternativa_1.Checked)
            {
                alternativa_1.ForeColor = Color.Red;
            }
            if (alternativa_2.Checked)
            {
                alternativa_2.ForeColor = Color.Red;
            }
            if (alternativa_3.Checked)
            {
                alternativa_3.ForeColor = Color.Green;
            }
        }

        private void proximo1_Click(object sender, EventArgs e)
        {
            categoriapa_2 categoriapa_2 = new categoriapa_2();
            categoriapa_2.ShowDialog();
        }
    }
}
