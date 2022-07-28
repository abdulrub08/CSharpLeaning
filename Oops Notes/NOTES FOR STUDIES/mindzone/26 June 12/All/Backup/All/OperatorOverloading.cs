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
    public partial class OperatorOverloading : Form
    {
        public OperatorOverloading()
        {
            InitializeComponent();
        }
        class Emp
        {
            private int sal;
            public Emp()//Cons
            {
            }
            public Emp(int x)//One arg. cons
            {
                sal = x;
            }
            public void Print()
            {
                MessageBox.Show(sal + "");
            }
            public static Emp operator +(Emp x, Emp y)
            {
                Emp e = new Emp();
                e.sal = x.sal + y.sal;
                return e;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Emp e1 = new Emp(5000);
            Emp e2 = new Emp(3000);
            Emp e3 = new Emp(12000);
            Emp total = new Emp();
            total = e1 + e2 + e3;
            total.Print();

        }
    }
}
