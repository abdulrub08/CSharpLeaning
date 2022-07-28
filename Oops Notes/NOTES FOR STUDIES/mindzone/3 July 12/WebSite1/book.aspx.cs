using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class book : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        if (ddlselected.Items.Count < 3)
        {
            for (int i = 0; i < ddlselected.Items.Count; i++)
            {
                if (ddlavailable.SelectedItem.ToString() == ddlselected.Items[i].ToString())
                {
                    lmsg.Text = "This book is already exists in the list.";
                    return;
                }
                //else
                //{
                //    ddlselected.Items.Add(ddlavailable.SelectedItem.ToString());
                //    return;
                //}
            }
            ddlselected.Items.Add(ddlavailable.SelectedItem.ToString());
        }
        else
        {
            lmsg.Text = "limit is over";
        }
    }
}