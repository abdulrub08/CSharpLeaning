using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewStaticClass_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        static class Test
        {
            //public void print()
            //{
            //    MessageBox.Show("Normal Method");
            //}
            public static void display()
            {
                MessageBox.Show("Static Method");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // Test t = new Test();
           // Test.display();
         //   Test t = new Test();
          //  t.print();
        }
    }
}
