using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            chart2.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            chart3.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            chart4.Series[0].Points.AddXY(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
