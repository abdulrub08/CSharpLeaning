using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewEveSealed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        sealed class Test
        {
            public void print()
            {
                MessageBox.Show("From Print");
            }
        }
        //class Best : Test
        //{

        //}
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.print();

        }
    }
}
