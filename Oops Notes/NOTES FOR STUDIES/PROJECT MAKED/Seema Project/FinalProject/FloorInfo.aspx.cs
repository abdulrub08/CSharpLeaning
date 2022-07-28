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

public partial class FloorInfo : System.Web.UI.Page
{
    public void ShowGridData()
    {
        string sql = "select FloorNo,Description,EntryDate,id from FloorInfo where ActiveStatus=1";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource=ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                actives=row[3].ToString();
                break;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            ShowGridData();
            lblid.Text = "";
            lblmode.Text = "Save";
        }
    }
    MyConnectionString cs = new MyConnectionString();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtFloorNo.Text == "")
        {
            lblmsg.Text = "Please enter the Floor No";
            txtFloorNo.Focus();
            return;
        }
        if (txtDescription.Text == "")
        {
            lblmsg.Text = "Please enter the Description";
            txtDescription.Focus();
            return;
        }
        if (lblmode.Text == "Save")
        {
            string sql = "insert into FloorInfo(FloorNo,Description,Remark,EntryDate,EntryPerson)values('" + txtFloorNo.Text + "','" + txtDescription.Text + "','" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is Saved Successfully";
                txtFloorNo.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
        else
        {
            string sql = "update FloorInfo set FloorNo='"+ txtFloorNo.Text +"',Description='"+ txtDescription.Text +"',Remark='"+ txtRemark.Text +"'where id='"+ lblid.Text +"'";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is Updated Successfully";
                txtFloorNo.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id=r.Cells[4].Text;
        string sql = "select FloorNo,Description,Remark from FloorInfo where id='"+ id +"'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        //string actives = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtFloorNo.Text = row[0].ToString();
                txtDescription.Text=row[1].ToString();
                txtRemark.Text=row[2].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }
}
