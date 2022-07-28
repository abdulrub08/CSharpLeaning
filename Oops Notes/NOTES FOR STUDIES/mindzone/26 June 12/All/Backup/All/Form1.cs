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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Emp
        {
            private int sal;
            public Emp()  //default cons
            {

            }
            public Emp(int x)  //one arg. cons
            {
                sal = x;

            }
            public void Print()
            {
                MessageBox.Show(sal + " ");

            }
            public static Emp operator +(Emp x, Emp y)
            {
                Emp t = new Emp();
                t.sal = x.sal + y.sal;
                return t;


            }
        }//Emp
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emp e1 = new Emp(5000);
            Emp e2 = new Emp(3000);
            Emp e3 = new Emp(12000);
            Emp Total = new Emp();
            Total = e1 + e2 + e3;
            Total.Print();
        }
    }
}
