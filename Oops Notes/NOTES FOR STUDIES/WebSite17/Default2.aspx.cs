using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string city = "";
        for (int i = 0; i < lstplace.Items.Count; i++)
        {
            if (lstplace.Items[i].Selected == true)
            {
                city = city + " " + lstplace.Items[i].ToString()+",";
            }
        }
        lblmsg.Text = txtname.Text + " wants to relocate in " + city;
    }
    protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
    {
        if (chkSelectAll.Checked == true)
        {
            for (int i = 0; i < lstplace.Items.Count; i++)
            {
                lstplace.Items[i].Selected = true;
            }
        }
        else
        {
            for (int i = 0; i < lstplace.Items.Count; i++)
            {
                lstplace.Items[i].Selected = false;
            }
        }
    }
}
