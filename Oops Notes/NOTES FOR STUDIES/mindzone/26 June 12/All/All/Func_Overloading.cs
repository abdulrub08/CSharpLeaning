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
    public partial class Func_Overloading : Form
    {
        public Func_Overloading()
        {
            InitializeComponent();
        }
        class Test
        {
            public void Print(float x)
            {
                MessageBox.Show("from float : " + x);

            }
            public void Print(double x)
            {
                MessageBox.Show("from double : " + x);
            }

            public void Print(decimal x)
            {
                MessageBox.Show("from decimal : " + x);
            }

        }//Test
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
           // t.Print(4.0);  //double
          // t.Print(4);  //error
           // t.Print(4f);   //float
         //   t.Print(4d);   //double
            t.Print(4m);   //decimal

        }
    }
}
