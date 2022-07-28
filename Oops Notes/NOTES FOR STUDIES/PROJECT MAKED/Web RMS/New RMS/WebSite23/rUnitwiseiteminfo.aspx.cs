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
using System.Data.SqlClient;

public partial class rUnitwiseiteminfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnprintall_Click(object sender, EventArgs e)
    {
        string sql = "select itemname,unitname,openingstock,mrp,saleprice from iteminfo";
        DataSet ds = new DataSet();
        ds=cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforunitwiseitem.aspx");

   
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "select itemname,unitname,openingstock,mrp,saleprice from iteminfo where unitname='"+ ddlunitname.SelectedItem.ToString() +"'";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforunitwiseitem.aspx");


    }
}
