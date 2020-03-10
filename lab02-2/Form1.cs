using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab02_2
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double u = .0;
            string result = "";
            if (comboBox1.Text == "Sin") u = Math.Sin(x);
            else if (comboBox1.Text == "Cos") u = Math.Cos(x);
            else if (comboBox1.Text == "Tan") u = Math.Tan(x);
            else result = "error";
            double y;
            if (result != "error" && u + x > -5)
            {
                y = Math.Pow(2 * u + 1, 2) / (7 * Math.PI);
                result = y.ToString();
            }
            else if (result != "error" && u + x <= -5 && u + x <= Math.Exp(-3))
            {
                y = Math.Pow(Math.Cos(u), 2) - Math.Sin(u / 3);
                result = y.ToString();
            }
            else if (result != "error" && u + x > Math.Exp(-3))
            {
                y = (Math.Log10(u + x) - Math.Exp(-x)) / (3.5 * x);
                result = y.ToString();
            }
            else result = "error";

            Result.Text = result;
            
        }
    }
}
