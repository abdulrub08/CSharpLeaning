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
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        interface myinterface
        {
            void callmethod();
            void Print();

        }
        
        public class Interface1 : myinterface
        {
            
            public Interface1()
            {
                // TODO: Add constructor logic here
            }

            public void callmethod()
            {
                MessageBox.Show("callmethod implemented!");
            }
            public void Print()
            {
                MessageBox.Show("Print method implemented!");
            }

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Interface1 inf1 = new Interface1();
            inf1.callmethod();
            inf1.Print();
            
        }
    }
}
