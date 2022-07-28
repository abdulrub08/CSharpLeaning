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

public partial class PrintFloorInfo : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select FloorNo from FloorInfo ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlFloorNo.Items.Add(row[0].ToString());
                }
                break;
            }
            ddlFloorNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
    }
    protected void btnPrintAll_Click(object sender, EventArgs e)
    {
        string sql = "select FloorNo,Description,EntryDate from FloorInfo";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        Session["MyDataset"] = ds;
        Session["PageName"] = "PrintFloorInfo";
        Response.Redirect("Report.aspx");

    }
    protected void btnPrint_Click(object sender, EventArgs e)
    {
        string sql = "select FloorNo,Description,EntryDate from FloorInfo where FloorNo='"+ ddlFloorNo.SelectedItem.ToString() +"'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        Session["MyDataset"] = ds;
        Session["PageName"] = "PrintFloorInfo";
        Response.Redirect("Report.aspx");

    }
}
