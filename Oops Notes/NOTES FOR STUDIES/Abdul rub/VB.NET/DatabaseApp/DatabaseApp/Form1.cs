using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.employeeDataSet.emp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.empBindingSource.Position < this.empBindingSource.Count - 1)
                this.empBindingSource.MoveNext(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.empBindingSource.Position >0)
                this.empBindingSource.MovePrevious ();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                this.empBindingSource.MoveFirst ();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.empBindingSource.MoveLast();
        }
    }
}
