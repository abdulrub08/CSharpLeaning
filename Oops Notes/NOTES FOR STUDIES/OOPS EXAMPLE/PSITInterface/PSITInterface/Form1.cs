using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        interface myinterface
        {
            void print();
            void display();
        }
            class Test :Best, myinterface
        {
            public void print()
            {
                MessageBox.Show("print");
            }
            public void display()
            {
                MessageBox.Show("display");
            }
        }
        class Best
        {
            public void show()
            {
                MessageBox.Show("From show");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            
        }
    }
}
