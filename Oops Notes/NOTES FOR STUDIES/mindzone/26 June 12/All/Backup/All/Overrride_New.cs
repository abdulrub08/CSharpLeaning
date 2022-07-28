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
    public partial class Overrride_New : Form
    {
        public Overrride_New()
        {
            InitializeComponent();
        }
        public class Square
        {
            public double x;

            // Constructor:
            public Square(double x)
            {
                this.x = x;
            }

            public virtual double Area()
            {
                return x * x;
            }
        }

        class Cube : Square
        {
            // Constructor:
            public Cube(double x)
                : base(x)
            {

            }

            // Calling the Area base method:
            public override double Area()
            {
                return (6 * (base.Area()));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = 5.2;
            Square s = new Square(x);
          Square c = new Cube(x);
            MessageBox.Show("Area of Square =  " + s.Area());
         MessageBox.Show("Area of Cube =  " + c.Area());
           MessageBox.Show("Area of Square =  " + s.Area());
     

        }
    }
}
