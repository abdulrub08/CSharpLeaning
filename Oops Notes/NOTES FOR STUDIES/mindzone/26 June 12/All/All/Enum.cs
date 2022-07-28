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
    public partial class Enum : Form
    {
        
        public Enum()
        {
            InitializeComponent();
        }
        //GD
        enum No1
        {
            sa = 15,
            ja = 12,
            ca = 20
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            i = (int)No1.sa;
            j = (int)No1.ja;
            k = (int)No1.ca;
            MessageBox.Show(i + " " + j + " " + k);

        }

        private void Enum_Load(object sender, EventArgs e)
        {

        }
    }
}
