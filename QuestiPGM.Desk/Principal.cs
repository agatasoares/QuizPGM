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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            splash tela = new splash();
            tela.ShowDialog();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1)
            {
                timer1.Enabled = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); // encerrar
        }

        private void button1_Click(object sender, EventArgs e)
        {
            categoriapa categoriapa = new categoriapa();
            categoriapa.ShowDialog();
        }
    }
}
