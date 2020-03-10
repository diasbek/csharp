using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(a.Text);
            int B = int.Parse(b.Text);

            int N;

            if (A < B)
            {
                N = B - A + 1;
                n.Text = N.ToString();
                string nums = "";
                for(int i = A; i <= B; i++)
                {
            
                    nums = nums  + c.ToString;
                } 
            
            }
            else
            {
                n.Text = "A>B";
            }
            
        }
    }
}
