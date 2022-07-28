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


public partial class Vcontactus : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "select name,address,mobileno,emailid,description,contacttimefrom,contacttimeto from contactus where entrydate between '" + txtfromdate.Text + "' and '" + txttodate.Text + "' ";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        Session["mydataset"] = ds;
    }
    protected void btnprint_Click(object sender, EventArgs e)
    {
        string sql = "select name,address,mobileno,emailid,description,contacttimefrom,contacttimeto from contactus where entrydate between '" + txtfromdate.Text + "' and '" + txttodate.Text + "' ";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["pagename"] = "Vcontactus";
        Session["mydataset"] = ds;
        Response.Redirect("Report.aspx");
    }

}
