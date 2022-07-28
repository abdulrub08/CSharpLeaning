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
    public partial class Abstract_Cls : Form
    {
        public Abstract_Cls()
        {
            InitializeComponent();
        }
        abstract class Shape
        {
            private int x = 10, y = 20;
            public void Print()
            {
                MessageBox.Show(x + " " + y);
            }
            public abstract void FindArea();
            //nO BODY
        }//Shape
        class Circle : Shape
        {
            private int r = 10;
            public override void FindArea()
            {
                double a = 3.14 * r * r;
                MessageBox.Show("Area is " + a);

            }
            //public abstract void p1();
            public void Display()
            {
                MessageBox.Show("Thanks");
            }
        }//Circle
        //class Test:Circle
        //{
        //    public override void p1()
        //    {
        //        MessageBox.Show("h");
        //    }

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            Circle Cir = new Circle();
            Cir.Print();
            Cir.FindArea();
            Cir.Display();
           // Shape Shp = new Circle(); //error
           // Shape Shp = new Test();

            //Shp.FindArea();
            
            


            
        }
    }
}
