using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MyNotepad
{
    public partial class frmMyNotepad : Form
    {
        public frmMyNotepad()
        {
            InitializeComponent();
        }

        private void frmMyNotepad_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(filename);
            txtNote.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string filename = saveFileDialog1.FileName;
            StreamWriter sw = new StreamWriter(filename);
            sw.Write(txtNote.Text);
            sw.Flush();
            sw.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNote.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            txtNote.Font = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtNote.ForeColor = colorDialog1.Color;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRun fr = new frmRun();
            fr.Show();
            

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp fh = new frmHelp();
            fh.Show();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                txtNote.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
            else
            {
                txtNote.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
        }
    }
}
