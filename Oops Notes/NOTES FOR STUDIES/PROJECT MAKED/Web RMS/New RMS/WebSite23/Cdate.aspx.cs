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

public partial class Cdate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // TextBox1.Text = DateTime.Now.ToString("mm/dd/yy");

    }
    protected void btncontinue_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            lblmsg.Text = "Select a Date.";
            TextBox1.Focus();
            return;
        }

        Session["cdate"] = TextBox1.Text;
        Response.Redirect("Home.aspx");
    }
}
