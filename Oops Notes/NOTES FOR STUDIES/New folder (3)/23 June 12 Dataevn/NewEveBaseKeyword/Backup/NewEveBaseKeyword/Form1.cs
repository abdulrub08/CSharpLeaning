using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewEveBaseKeyword
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
            public int a = 20;

        }
        class Best : Test
        {
            public int a = 200;
            public void print(int a)
            {
                MessageBox.Show(""+a);
                MessageBox.Show(""+this.a);
                MessageBox.Show("" + base.a);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Best b = new Best();
            b.print(2000);
            MessageBox.Show(""+b.a);
        }
    }
}
