using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITFunction_Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        class Test
        {
            public void print()
            {
                MessageBox.Show("From 0 args.");
            }
            public void print(int x)
            {
                MessageBox.Show("From 1 int args.");
            }
            public void print(string x)
            {
                MessageBox.Show("From 1 string args.");
            }
            public void print(int x,string y)
            {
                MessageBox.Show("From 2 args.");
            }
            //public void print()
            //{
            //    MessageBox.Show("From 1 int args.");
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Test t = new Test();
            t.print();
            t.print(10);
            t.print("hello");
            t.print(10, "hello");

        }
    }
}
