using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassAndObject
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
            private int i = 10;
            public int Print()
            {
                MessageBox.Show("Value =");
                return i;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            //t.Print();
            MessageBox.Show(""+t.Print());
            
        }
    }
}
