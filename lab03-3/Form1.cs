using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double t = double.Parse(textBox1.Text);
            double price = 0;
            int code = Int32.Parse(comboBox1.Text);

            string error = "";

            switch (code)
            {
                case 44: price = 18; break;
                case 45: price = 11; break;
                case 46: price = 13; break;
                case 48: price = 15; break;
                default: error = "Code is not matchet with the list"; break;
            }

            double total = 0;

            if (error == "")
            {
                total = price * t;
                label4.Text = total.ToString();
            }
            else
            {
                label4.Text = error;
            }
     
                

        

        }
    }
}
