﻿using System;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            else if(alternativa_1.Checked)
            {
                alternativa_1.ForeColor = Color.Red;
            }
            else if (alternativa_2.Checked)
            {
                alternativa_2.ForeColor = Color.Red;
            }
            else if (alternativa_3.Checked)
            {
                alternativa_3.ForeColor = Color.Green;
            }
        }   
        

        
    }
}
