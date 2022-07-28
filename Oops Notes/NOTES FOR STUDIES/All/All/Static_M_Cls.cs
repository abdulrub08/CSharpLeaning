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
    public partial class Static_M_Cls : Form
    {
        public Static_M_Cls()
        {
            InitializeComponent();
        }
        static class Test
        {
            public static void Print(string s)
            {
                
                string[] x=s.Split('.');
                for (int i=0;i<x.Length;i++)
                {
                    MessageBox.Show(x[i]);
                    
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Test.Print(textBox1.Text);
           //Test t = new Test();   //error
        
                      
        }

     
    }
}
