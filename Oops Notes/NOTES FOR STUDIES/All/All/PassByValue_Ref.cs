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
    public partial class PassByValue_Ref : Form
    {

        public PassByValue_Ref()
        {
            InitializeComponent();
        }
        class Test
        {
            public void Swap(int x, ref int y)
            {
                int t = x;
                x = y;
                y = t;
            }//Swap
        }//Test
        private void PassByValue_Ref_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10, b =20;
            Test t = new Test();
            t.Swap(a, ref b);
            MessageBox.Show(a + " " + b);

        }
    }
}
