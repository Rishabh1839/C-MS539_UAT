﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_MS549
{
    public partial class Form8 : Form
    {
        int sc8;
        public Form8(int score)
        {
            InitializeComponent();
            sc8 = score;
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sc8--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sc8++;
            MessageBox.Show("Correct!");
            MessageBox.Show("Your score is " + sc8.ToString());
            Form9 f9 = new Form9(sc8);
            f9.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sc8--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sc8--;
            MessageBox.Show("Incorrect Answer, Try Again!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
