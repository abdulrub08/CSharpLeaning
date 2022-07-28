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

public partial class rPartyinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select partyname from partyinfo";
            DataSet ds = new DataSet();
            ds = cls.SelectQuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlpartyname.Items.Add(row[0].ToString());

                }
                break;
            }

        }
    }
    protected void btnprint_Click(object sender, EventArgs e)
    {
        string sql = "select partyname,address,contactno,personname,mobileno from partyinfo";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforparty.aspx");

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "select partyname,address,contactno,personname,mobileno from partyinfo where partyname='" + ddlpartyname.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforparty.aspx");
    }
}
