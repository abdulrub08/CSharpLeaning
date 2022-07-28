using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn1_Click(object sender, EventArgs e)
    {
        lst2.Items.Add(lst1.SelectedItem.Text);
        lst1.Items.RemoveAt(lst1.SelectedIndex);
    }
    protected void btn2_Click(object sender, EventArgs e)
    {
        lst1.Items.Add(lst2.SelectedItem.Text);
        lst2.Items.RemoveAt(lst2.SelectedIndex);

    }
    protected void btn3_Click(object sender, EventArgs e)
    {
        
       //foreach(int i in lst1.Items)
       //{
       //    lst2.Items.Add(lst1.Items[i].Text);
       //}
        //for (int i = 0; i < lst1.Items.Count; i++)
        //{
        //    lst2.Items.Add(lst1.)
        //}
       // ListItem l = lst1.SelectedItem;
       
    }
}