using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вычисление
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);         
            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();       
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine +
            " Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine +
            " Z = " + z.ToString();
            double a = Math.Tan(x + y) *
            Math.Tan(x + y);
            double v;
            v = (1 + Math.Pow(Math.Sin(x + y), 2) / Math.Abs(x - ((2 * y) / 1 + x * x * y * y))) * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);                   
            textBox4.Text += Environment.NewLine +
            " Результат V = " + v.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
