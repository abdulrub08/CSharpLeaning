using System;
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

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void rbtMale_CheckedChanged(object sender, EventArgs e)
    {
        rbtFeMale.Checked = false;
        rbtMale.Checked = true;
    }
    protected void rbtFeMale_CheckedChanged(object sender, EventArgs e)
    {
        rbtFeMale.Checked = true;
        rbtMale.Checked = false;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtname.Text == "")
        {
            lblmsg.Text = "Enter the name";
            txtname.Focus();
            return;
        }
        if (rbtMale.Checked == false && rbtFeMale.Checked == false)
        {
            lblmsg.Text = "Select a gender";
            return;
        }
        if (ddlcity.SelectedIndex == 0)
        {
            lblmsg.Text = "Select a city";
            ddlcity.Focus();
            return;
        }



        if (rbtMale.Checked == true)
        {
            lblmsg.Text = "Mr. " + txtname.Text + " holds " + rbtlQualification.SelectedItem.ToString();
        }
        else if (rbtFeMale.Checked == true)
        {
            lblmsg.Text = "Ms. " + txtname.Text + " holds " + rbtlQualification.SelectedItem.ToString();
        }
    }
}
