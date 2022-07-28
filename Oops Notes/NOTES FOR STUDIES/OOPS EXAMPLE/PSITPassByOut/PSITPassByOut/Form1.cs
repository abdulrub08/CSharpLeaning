using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITPassByOut
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
            public void sum(int x, int y, out int z)
            {
                z = x + y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20, c;
            Test t = new Test();
            t.sum(a,b,out c);
            MessageBox.Show("Total ="+c);

        }
    }
}
