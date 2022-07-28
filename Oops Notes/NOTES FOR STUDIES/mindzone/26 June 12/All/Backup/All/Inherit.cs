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
    public partial class Inherit : Form
    {
        public Inherit()
        {
            InitializeComponent();
        }
        class Emp
        {
            private int Eno = 101;
            protected int sal = 5000;
            public int i = 10;
            public void Print()
            {
                MessageBox.Show(Eno + " " + sal);
            }
        }//Emp
        class Bonus : Emp
        {
            
            private int b, total;
            public void calculate(int x)
            {
                
                b = x;
                //Print();
                total = sal + b;
                MessageBox.Show("Total sal is :" + total);
            }
        }//Bonus
        private void button1_Click(object sender, EventArgs e)
        {
            ////Emp e2 = new Emp();
            
            DialogResult dr;
            dr=MessageBox.Show("Have reached the targets","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Bonus x = new Bonus();
                x.calculate(3000);
                
            }
            else
            {
                Emp Y = new Emp();
                Y.Print();
                
            }
            
        }

        private void Inherit_Load(object sender, EventArgs e)
        {

        }
    }
}
