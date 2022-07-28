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
    public partial class Static_Var : Form
    {
        public Static_Var()
        {
            InitializeComponent();
        }
        class Test
        {
            public int i;//Instance Var
            public static int s;//Static var
            static Test()   //Static Cons
            {
                s = 0;
               //i = 0; //error
            }
            public Test()  //Cons
            {
                i = i + 1;
                s = s + 1;
                MessageBox.Show(i + "    " + s);

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
