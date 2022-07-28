using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class InboxMail : System.Web.UI.Page
{
    //GD
    Class1 cls = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select fromempid,subject,entrydate as Date from outboundmail where toempid='" + Session["empid"].ToString() + "'";
            DataSet ds = new DataSet();
            ds = cls.selectquery(sql);
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
