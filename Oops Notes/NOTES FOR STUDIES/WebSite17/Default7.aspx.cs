using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = "";
        int j=0;
        for(int i=0;i<CheckBoxList2.Items.Count;i++)
            if (CheckBoxList2.Items[i].Selected == true )
                        j++;
            
        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
            if (CheckBoxList2.Items[i].Selected == true && j>1)
            {
                Label1.Text = Label1.Text + " " + CheckBoxList2.Items[i].Text + ",";
                j--;
            }
            else if (CheckBoxList2.Items[i].Selected == true)
            {
                Label1.Text = Label1.Text + " " + CheckBoxList2.Items[i].Text + ".";
                j--;
            }

                
    }
}