using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassByValue_Ref
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
            public void swap(ref int x, int y)//formal args.
            {
                int z = x;
                x = y;
                y = z;
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a=10 , b = 20;
            Test t = new Test();
            t.swap(ref a, b);//actual args.
            MessageBox.Show(a+"     "+b);
        }
    }
}
