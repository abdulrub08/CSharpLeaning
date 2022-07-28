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

public partial class Groupinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    public void ShowGridData()
    {
        string sql = "select id,groupname,description,remark from groupinfo where activestatus= 1";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ShowGridData();
            lblid.Text = "";
            lblmode.Text = "save";
        }
    }
     public void clr()
    {
        txtgroupname.Text = "";
        txtdescription.Text = "";
        txtremark.Text = "";

    }
     protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
     {
         GridViewRow r = GridView1.SelectedRow;
         String id = r.Cells[1].Text;
         string sql = "select groupname,description,remark from groupinfo where id=" + id + "";
         DataSet ds = new DataSet();
         ds = cls.SelectQuery(sql);
         DataTable dt = ds.Tables["a"];
         foreach (DataColumn col in dt.Columns)
         {
             foreach (DataRow row in dt.Rows)
             {
                 txtgroupname.Text=row[0].ToString();
                 txtdescription.Text = row[1].ToString();
                 txtremark.Text=row[2].ToString();
                 lblid.Text = id;
                 lblmode.Text = "update";
                 return;
             }
         }
     }
     protected void btnsubmit_Click(object sender, EventArgs e)
     {
         if (txtgroupname.Text == "")
         {
             lblmsg.Text = "Enter the group name:";
             txtgroupname.Focus();
             return;
         }
         if (lblmode.Text == "save")
         {
             string sql = "insert into groupinfo(groupname,description,remark,entrydate)values('" + txtgroupname.Text + "','" + txtdescription.Text + "','" + txtremark.Text + "','" + DateTime.Now.ToString() + "')";
             int a = 0;
             a = cls.ExecuteQuery(sql);
             if (a == 0)
             {
                 lblmsg.Text = "Data is not saved";
             }
             else
             {
                 lblmsg.Text = "Data is saved";
                 clr();
                 txtgroupname.Focus();
             }
         }
         else
         {
             string b=Session["Loginname"].ToString();
             SqlCommand cm = new SqlCommand();
             string sql=("update groupinfo set groupname='"+ txtgroupname.Text +"',description='"+ txtdescription.Text +"',remark='"+ txtremark.Text +"' where id="+ lblid.Text +"");
             int a = 0;
             a = cls.ExecuteQuery(sql);
             if (a == 0)
             {
                 lblmsg.Text = "Data is not Updated";
             }
             else 
             {
                 lblmsg.Text = "Data is Updated";
                 clr();
                 ShowGridData();
             }
 
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