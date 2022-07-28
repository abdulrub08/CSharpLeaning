using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITCons_Des
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
            public Test()//Normal Cons.
            {
                MessageBox.Show("From Cons");
            }
            ~Test()//Des.
            {
                MessageBox.Show("From Des");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();
        }
    }
}
