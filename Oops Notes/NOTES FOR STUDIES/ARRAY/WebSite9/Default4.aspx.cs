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

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ddlstate_SelectedIndexChanged(object sender, EventArgs e)
    {
        ddlcity.Items.Clear();
        switch (ddlstate.SelectedIndex)
        {
            case 0:
                ddlcity.Items.Add("Hyderabad");
                ddlcity.Items.Add("Tirupati");
                ddlcity.Items.Add("Vijaywada");
                break;
            case 1:
                ddlcity.Items.Add("Indore");
                ddlcity.Items.Add("Bhopal");
                ddlcity.Items.Add("Jabalpur");
                break;
            case 2:
                ddlcity.Items.Add("Kanpur");
                ddlcity.Items.Add("Lucknow");
                ddlcity.Items.Add("Agra");
                break;
        }
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        lblmsg.Text = txtname.Text + " lives in " + ddlcity.SelectedItem.ToString() + " which is located in " + ddlstate.SelectedItem.ToString();

    }
    protected void ddlcity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
