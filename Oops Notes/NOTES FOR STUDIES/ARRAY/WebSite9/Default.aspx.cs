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
    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        if (txtLoginName.Text == "admin" && txtPwd.Text == "123")
        {
            Response.Redirect("Default2.aspx");
        }
        else
        {
            lblMsg.Text = "Invalid login name or password";
        }
    }
    protected void txtPwd_TextChanged(object sender, EventArgs e)
    {

    }
}
