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

public partial class rCompanyinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select companyname from companyinfo";
            DataSet ds = new DataSet();
            ds = cls.SelectQuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlcompanyname.Items.Add(row[0].ToString());

                }
                break;
            }
        }

    }
    protected void btnprintall_Click(object sender, EventArgs e)
    {
        string sql = "select companyname,address,contactno,contactperson,mobileno from companyinfo";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforcompany.aspx");

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "select companyname,address,contactno,contactperson,mobileno from companyinfo where companyname='"+ ddlcompanyname.SelectedItem.ToString() +"'";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforcompany.aspx");

    }
    protected void join(object sender, EventArgs e)
    {
        ddlcompanyname.Items.Insert(0,"--Select the company name--");
    }
}
