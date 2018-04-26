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
    public partial class armamento2 : Form
    {
        public armamento2()
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
                radioButton2.ForeColor = Color.Red;
            }
            if (radioButton3.Checked)
            {
                radioButton3.ForeColor = Color.Green;
            }
            if (radioButton4.Checked)
            {
                radioButton4.ForeColor = Color.Red;
            }
        }
    }
}
