using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UDCEvents
{
    public partial class MyNewButtonEvents : UserControl
    {
        public MyNewButtonEvents()
        {
            InitializeComponent();
        }
        //GD
        public delegate void Dname();
        public event Dname Abc;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("From Event");
            Abc();
        }
    }
}
