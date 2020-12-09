using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       
        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet ,toplam;
            misir = Convert.ToInt16(textBox1.Text);
            cay = Convert.ToInt16(textBox2.Text);
            su = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + cay * 2 + su + bilet * 8;
            label15.Text = toplam +" TL ";

            kasatutar = kasatutar + toplam;
            label16.Text = kasatutar + " TL ";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
    }
}
