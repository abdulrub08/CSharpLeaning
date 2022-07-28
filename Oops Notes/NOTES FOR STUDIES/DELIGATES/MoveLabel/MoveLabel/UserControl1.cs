using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveLabel
{
    public partial class MoveLabel : UserControl
    {
        public MoveLabel()
        {
            InitializeComponent();
        }
        //GD
        public string LText
        {
            set { label1.Text = value; }
            get { return label1.Text; }

        }
        public Color LBColor
        {
            set { label1.BackColor = value; }
            get { return label1.BackColor; }

        }
        public Color LFColor
        {
            set { label1.ForeColor = value; }
            get { return label1.ForeColor; }

        }
        public int LSpeed
        {
            set
            {
                timer1.Interval = value; 
              timer2.Interval = value; }

            get { return timer1.Interval; }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < 400)
            {
                label1.Left = label1.Left + 3;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Left >5)
            {
                label1.Left = label1.Left - 3;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = false;
            }
        }
    }
}
