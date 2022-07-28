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
    public partial class Classes_Objects : Form
    {
        public Classes_Objects()
        {
            InitializeComponent();
        }
        class Test
        {
            private int a, b; 
            //Fields, reference types
            //because class is reference type
            public void Read(int x, int y)
            {//x and y value types, local variables
                a = x;
                b = y;
                
            }//Read
            public void Print()
            {
                
                int k = a + b;
                MessageBox.Show("Sum : " + k);
                
            }//Print
        }//Test

        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            
            t.Read(10, 20);
            t.Print();
            
          // Test t1=new Test();
          // t1.Print();
            Test t2 = t;
            t2.Print();
        }

        private void Classes_Objects_Load(object sender, EventArgs e)
        {

        }
    }
}
