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
    public partial class Override : Form
    {
        public Override()
        {
            InitializeComponent();
        }
        class A
        {
            public int x = 10;

        }//A
        class B : A
        {
            private int x = 100;
            public void Print(int x)
            {
                MessageBox.Show(this.x + " ");//
                 MessageBox.Show(base.x + " ");//
                MessageBox.Show(x + " ");//
            }//Print
        }//B
        private void button1_Click(object sender, EventArgs e)
        {
            B obj = new B();
            obj.Print(1000);
            MessageBox.Show(obj.x + " ");//
        }
    }
}
