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

public partial class Aduser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Session["Loginname"].ToString() == "admin")
            {

            }
            else
            {
                Response.Redirect("accessdenied.aspx");
            }
        }

    }
    Class1 cls = new Class1();
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select username,loginname,address,contactno,remark,activestatus from userinfo where loginname='" + ddlloginname.SelectedItem.ToString() + "' ";

        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DetailsView1.DataSource = ds.Tables["a"];
        DetailsView1.DataBind();

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
        if (actives == "True")
        {
            btnupdate.Text = "Deactivate user";
        }
        else
        {
            btnupdate.Text = "Activate user";
        }
    }
    protected void btnupdate_Click(object sender, EventArgs e)
    {
        string sql = "";
        if (btnupdate.Text == "Activate User")
        {
            sql = "update userinfo set activestatus=1 where loginname='" + ddlloginname.SelectedItem.ToString() + "'";

        }
        else
        {
            sql = "update userinfo set activestatus=0 where loginname='" + ddlloginname.SelectedItem.ToString() + "'";
        }
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not activated";
        }
        else
        {
            lblmsg.Text = "Data is activated";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
    

