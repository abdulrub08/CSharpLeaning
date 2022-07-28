using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UDCApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void myNewButtonEvents1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("hello");
        }

        private void myNewButtonEvents1_Abc()
        {
            MessageBox.Show("From Form");
        }
    }
}
