using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITInherit2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        class Shape
        {
            public Shape()
            {
                MessageBox.Show("From Shape");
            }
        }
        class Circle:Shape
        {
            public Circle()
            {
                MessageBox.Show("From Circle");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Shape s1=new Shape();
            Circle c1=new Circle();
            Shape s2=new Circle();
            //Circle c2=new Shape();
        }
    }
}
