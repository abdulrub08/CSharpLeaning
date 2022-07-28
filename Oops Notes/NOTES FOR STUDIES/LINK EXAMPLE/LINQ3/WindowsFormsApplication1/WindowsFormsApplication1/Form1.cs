using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void F2()
        {
            XDocument xmlDoc = XDocument.Load(@"D:\New.xml");
            var q = from c in xmlDoc.Descendants("site")
                    where c.Attribute("technical").Value == "true"
                    select (string)c.Element("name") + " ==>" + (string)c.Element("url");
            foreach (string name in q)
            {
                MessageBox.Show("Site:   " + name);
            }
        }
        public void F3()
        {
            XDocument xmlDoc = XDocument.Load(@"D:\New.xml");
            var q = from c in xmlDoc.Descendants("site")
                    where c.Attribute("technical").Value == "false"
                    select new
                    {
                        name = c.Element("name").Value,
                        url = c.Element("url").Value
                    };
            foreach (var obj in q)
            {
               MessageBox.Show("Site: " + obj.name + " -- " + obj.url);
            }
        }
        public void F1()
        {
            XDocument xmlDoc = XDocument.Load(@"D:\New.xml");
            var q = from c in xmlDoc.Descendants("site")
                    select (string)c.Element("name") + " -- " + (string)c.Element("url");

            foreach (string name in q)
            {
                MessageBox.Show("Site:   " + name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //F1();
           //F2();
          F3();

        }
    }
}
