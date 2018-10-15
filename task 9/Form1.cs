using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_9
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

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);

            double a = 4 * Math.PI * r * r;

            label11.Text = "the answer is " + a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox4.Text);

            double h = Convert.ToDouble(textBox3.Text);

            double an = Math.PI * r * (r + Math.Sqrt(r * r + h * h));

            label10.Text = "the answer is " + an;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox5.Text);

            double an = 6 * a * a;

            label17.Text = "the answer is " + an;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            double l = Convert.ToDouble(textBox9.Text);
            double h = Convert.ToDouble(textBox8.Text);
            double w = Convert.ToDouble(textBox7.Text);

            double an = l * h * w;

            label18.Text = "the answer is " + an;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox10.Text);

            double h = Convert.ToDouble(textBox11.Text);

            double an = 2 * r * Math.PI * h + 2 * Math.PI * r * r;

            label19.Text = "the answer is " + an;
        }
    }
}
