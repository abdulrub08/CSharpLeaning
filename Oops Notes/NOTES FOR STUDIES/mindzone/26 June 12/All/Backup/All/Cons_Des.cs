using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace All
{
    public partial class Cons_Des : Form
    {
        public Cons_Des()
        {
            InitializeComponent();
        }
        class Test
        {
            public Test() //Cons
            {
                MessageBox.Show("From Cons");
            }
            ~Test() //Des
            {
                MessageBox.Show("From Des");
            }
        }//Test
        private void button1_Click(object sender, EventArgs e)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();

        }
    }
}
