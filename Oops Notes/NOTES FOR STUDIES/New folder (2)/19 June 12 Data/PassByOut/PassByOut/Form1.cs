using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PassByOut
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
            public void show(int x, int y, out int z)
            {
                z = x + y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10, b = 30, c=10;
            Test t = new Test();
            t.show(a, b, out c);
            MessageBox.Show("Total :"+c);

        }
    }
}
