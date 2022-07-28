using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] x = new int[] { 5, 6, 2, 3, 5, 7, 2, 1, 2, 6, 9 };
            // print all values
       //   var v = from i in x select i;
            
            // print distinct values
            //var v = (from i in x select i).Distinct();

            ////// multiply each element with 5
     //  var v = from i in x select i * 5;
            
            // Conditional values
          //var v = from i in x where i > 5 select i;
           
            // sort the values
         var v = from i in x orderby i ascending select i;
           
            
            string res = "";
            foreach (int a in v)
            {
                res = res + " " + a;
                MessageBox.Show(res);

             }
            ////int s = x.Sum();
            ////MessageBox.Show(s + "");
        }
    }
}
