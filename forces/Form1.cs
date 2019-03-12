﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }
        double asin(double x)
        {
            return (Math.Asin(x * 180.0 / Math.PI));
        }
        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }
        double acos(double x)
        {
            return (Math.Acos(x) * 180.0 / Math.PI);
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Force = double.Parse(textBox1.Text);
            double angle = double.Parse(textBox2.Text);
            double Fx = Force * cos(angle);
            double Fy = angle * sin(Force);

            MessageBox.Show("Fx =" + (Fx.ToString("N3") + "\n"));
            MessageBox.Show("Fy =" + (Fx.ToString("N3") + "\n"));
        }
    }

}
 