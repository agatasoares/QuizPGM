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
    public partial class splash : Form
    {
        private int pro;
        public splash()
        {
            InitializeComponent();
            pro = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pro == 0)
            {
                progressBar1.Value = 20;
                label1.Text = "Carregando 20%";
                pro = 20;
            }
            else if (pro == 20)
            {
                progressBar1.Value = 40;
                label1.Text = "Carregando 40%";
                pro = 40;
            }
            else if (pro == 40)
            {
                progressBar1.Value = 60;
                label1.Text = "Carregando 60%";
                pro = 60;
            }
            else if (pro == 60)
            {
                progressBar1.Value = 80;
                label1.Text = "Carregando 80%";
                pro = 80;
            }
            else if (pro == 80)
            {
                progressBar1.Value = 100;
                label1.Text = "Incializando...";
                pro = 100;
            }
            else if (pro == 100)
            {
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
