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

public partial class UpdateAddPayment : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select id,RegNo,Amount,Tax,Discount,TotalAmount,Description from AddPayment";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();
            Session["id"] = "0";
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[1].Text;
        Session["id"] = id;
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        if (Session["id"].ToString() == "0")
        {
            lblmsg.Text = "Select The Data from Grid";
            return;
        }
        else
        {
            Session["mode"] = "Update";
            Response.Redirect("AddPayment.aspx");
        }
    }
}
