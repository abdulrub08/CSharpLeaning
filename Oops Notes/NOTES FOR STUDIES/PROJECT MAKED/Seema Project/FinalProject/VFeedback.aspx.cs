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

public partial class VFeedback : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnShow_Click(object sender, EventArgs e)
    {
        string sql = "select Name,Address,MobileNo,EmailID,Description,OutOf10 from Feedback where EntryDate between '"+ txtFromDate.Text +"' and '"+ txtToDate.Text +"'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives = row[5].ToString();
                break;
            }
        }
        Session["Mydataset"] = ds;
    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        Session["PageName"] = "VFeedback";
        Response.Redirect("Report.aspx");
    }
}
