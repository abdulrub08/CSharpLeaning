using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtname_TextChanged(object sender, EventArgs e)
    {
        if (txtname.Text == "ankur" && txtpwd.Text == "123")
        {
            Response.Redirect("Default3.aspx");
        }
        else
        {
            lblmsg.Text = "invalid username or password";
        }
    }
}