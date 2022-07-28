using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewEveInherit1
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
            private int empno = 101;
            protected int sal = 5000;
            public int deptno = 22;
            public void basicsal()
            {
                MessageBox.Show(empno+"   "+sal);
            }
        }//Test
        class Best : Test
        {
            public void bonus(int b)
            {
                int total = sal + b;
                MessageBox.Show("Total sal="+total);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr=MessageBox.Show("Have you reached the target?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Best b = new Best();
                b.bonus(2000);

            }
            else
            {
                Test t = new Test();
                t.basicsal();
            }
        }
    }
}
