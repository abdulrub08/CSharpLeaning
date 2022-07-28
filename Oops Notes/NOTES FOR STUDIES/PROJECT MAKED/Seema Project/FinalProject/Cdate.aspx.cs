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
        txtSelectDate.Text = DateTime.Now.ToString("MM / dd / yyyy");
    }
    protected void btnContinue_Click(object sender, EventArgs e)
    {        
        if (txtSelectDate.Text == "")
        {
            lblmsg.Text = "Please first select a date";
            txtSelectDate.Focus();
            return;
        }            
            Session["cdate"]=txtSelectDate.Text;
            Response.Redirect("Home1.aspx");
     }
}
