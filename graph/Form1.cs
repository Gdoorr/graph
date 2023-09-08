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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         Form2  f1 = new Form2();
                    f1.Show();
                    this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3 fr1 = new Form3();
                        fr1.Show();
                        this.Hide();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    Graphics graphics = pictureBox1.CreateGraphics();
        //    Pen pen = new Pen(Color.Black, 3f);

        //    Point[] points = new Point[1000];

        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 10 + 200));
        //    }
        //    graphics.DrawLines(pen, points);
        //}
    }
}
