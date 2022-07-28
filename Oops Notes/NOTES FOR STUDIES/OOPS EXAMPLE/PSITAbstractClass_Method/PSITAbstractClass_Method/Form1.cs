using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITAbstractClass_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        abstract class Test
        {
            public void print()
            {
                MessageBox.Show("from print");
            }
            public abstract void display();
            
        }
        class Best : Test
        {
            public void show()
            {
                MessageBox.Show("from show");
            }
            public override void display()
            {
                MessageBox.Show("display method implemented");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Test t=new Test();   error
            Test t = new Best();
            Best b = new Best();
            b.display();
        }
    }
}
