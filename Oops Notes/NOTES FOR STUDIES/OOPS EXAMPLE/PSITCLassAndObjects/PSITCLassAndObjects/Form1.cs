using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSITCLassAndObjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //GD
        //General Decleration
        class Test
        {
            int i = 20;//Fields or Instance var.
            public int print()//method
            {
                MessageBox.Show("Value : ");
                return i;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            int a = t.print();
            MessageBox.Show(""+a);
        }
    }
}
