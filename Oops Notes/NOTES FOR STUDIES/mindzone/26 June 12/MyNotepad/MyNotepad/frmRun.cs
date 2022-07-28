using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyNotepad
{
    public partial class frmRun : Form
    {
        public frmRun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //first add this     using System.Diagnostics;
            Process.Start(textBox1.Text);
        }
    }
}
