using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace All
{
    public partial class Inherit2 : Form
    {
        public Inherit2()
        {
            InitializeComponent();
        }
        class Shape
        {
            public Shape() //Cons
            {
                MessageBox.Show("From Shape");

            }
        }
        class Circle : Shape
        {
            public Circle() //Cons
            {
                MessageBox.Show("From Circle");
            }
        }
        class Square : Shape
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Shape shp = new Shape();
           Circle Cir = new Circle();
           Shape shp1 = new Circle();
          //Circle Cir1 = new Shape();

        }

    }
}
