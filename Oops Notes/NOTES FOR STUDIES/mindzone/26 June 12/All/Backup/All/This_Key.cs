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
    public partial class This_Key : Form
    {
        public This_Key()
        {
            InitializeComponent();
        }
        class Test
        {
            string abc = "C#";
            public void add(string abc)
            {
               this.abc = this.abc + abc;
                                
            }
            public void display()
            {
                MessageBox.Show(abc);
            }
        }//Test
       

        private void button1_Click(object sender, EventArgs e)
        {
            string a = ".Net";
            Test t = new Test();
            t.add(a);
            t.display();

        }
        private void This_Key_Load(object sender, EventArgs e)
        {

        }
    }
}
