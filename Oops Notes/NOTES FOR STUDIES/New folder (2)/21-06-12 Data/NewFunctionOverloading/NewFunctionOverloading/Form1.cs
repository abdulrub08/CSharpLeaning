using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewFunctionOverloading
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
                MessageBox.Show("From Zero args.");
            }
            public void print(int x)
            {
                //int a=10;
                MessageBox.Show("From one int args.");
                //return a;

            }
            public void print(string x)
            {
                MessageBox.Show("From one string args.");
            }
            public void print(int y,string x)
            {
                MessageBox.Show("From two args.");
            }
            public void print(float x)
            {
                MessageBox.Show("From one float args.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.print();
            t.print(10);
            t.print("hello");
            t.print(10, "hello");
            t.print(10.2f);

        }
    }
}
