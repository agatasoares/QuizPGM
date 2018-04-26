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
    public partial class categoriapa_2 : Form
    {
        public categoriapa_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(alternativa_1_2.Checked)
            {
                alternativa_1_2.ForeColor = Color.Red;
            }
            if(altrenativa_2_2.Checked)
            {
                altrenativa_2_2.ForeColor = Color.Green;
            }
            if(alternativa_3_2.Checked)
            {
                alternativa_3_2.ForeColor = Color.Red;
            }
        }

        private void proximo2_Click(object sender, EventArgs e)
        {
            armamento armamento = new armamento();
            armamento.ShowDialog();
        }
    }
}
