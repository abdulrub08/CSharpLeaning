using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewStaticVar_Cons
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
            public int i = 10;//instance var.
            public static int s = 20;//static var.
            static Test()//static cons.
            {
                s = 50;
            }
            public Test()//Normal Cons.
            {
                i = i + 10;
                s = s + 10;
                MessageBox.Show(i+"    "+s);
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
