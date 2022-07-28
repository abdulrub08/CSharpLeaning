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
    public partial class PassByOut : Form
    {
        public PassByOut()
        {
            InitializeComponent();
        }
        class Test
        {
            public void Add(int x, int y, out int z)
            {
                z = x + y;

            }//Add
        }//Test
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20, c;
            Test t = new Test();
            t.Add(a, b, out c);
            
            MessageBox.Show(c + " ");

        }

        private void PassByOut_Load(object sender, EventArgs e)
        {

        }
    }
}
