using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace All
{
    public partial class Sealed : Form
    {
        public Sealed()
        {
            InitializeComponent();
        }
        sealed class Test
        {
            public void OpenSoftware(string s)
            {
                Process.Start(s);
 //using System.Diagnotics is required for process cls.
                
            }
        }//Test
       //Class Best:Test  
       //{

        //} //        error
    
        private void button1_Click(object sender, EventArgs e)
        {
            new Test().OpenSoftware(textBox1.Text);

        }
    }
}
