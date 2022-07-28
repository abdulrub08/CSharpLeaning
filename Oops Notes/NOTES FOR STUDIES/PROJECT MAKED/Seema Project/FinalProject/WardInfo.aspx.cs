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

public partial class WardInfo : System.Web.UI.Page
{
    public void ShowGridData()
    {
        string sql = "select FloorNo,WingName,WardNo,Description,EntryDate,id from WardInfo where ActiveStatus=1";
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
    }
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
            ShowGridData();
            lblid.Text = "";
            lblmode.Text = "Save";
        }
    }
    MyConnectionString cs = new MyConnectionString();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if (txtWardNo.Text == "")
        {
            lblmsg.Text = "Please the Ward No";
            txtWardNo.Text = "";
            return;
        }
        if (lblmode.Text == "Save")
        {
            string sql = "insert into WardInfo(FloorNo,WingName,WardNo,Description,Remark,EntryDate,EntryPerson)values('" + ddlFloorNo.SelectedItem.ToString() + "','" + ddlWingName.SelectedItem.ToString() + "','" + txtWardNo.Text + "','" + txtDescription.Text + "','" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is successfully Saved";
                //ddlFloorNo.Items.Clear();
                ddlWingName.Items.Clear();
                txtWardNo.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
        else
        {
            string sql = "update WardInfo set FloorNo='" + ddlFloorNo.SelectedItem.ToString() + "',WingName='" + ddlWingName.SelectedItem.ToString() + "',WardNo='" + txtWardNo.Text + "',Description='" + txtDescription.Text + "',Remark='" + txtRemark.Text + "'where id='"+ lblid.Text +"'";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is successfully Updated";
                //ddlFloorNo.Items.Clear();
                ddlWingName.Items.Clear();
                txtWardNo.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
    }
    protected void ddlFloorNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select WingName from WingInfo where FloorNo='" + ddlFloorNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                ddlWingName.Items.Add(row[0].ToString());
            }
            break;
        }
        ddlWingName.Items.Insert(0, new ListItem("--Please Select--", "0"));
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[6].Text;
        string sql = "select FloorNo,WingName,WardNo,Description,Remark from WardInfo where id='" + id + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                ddlFloorNo.SelectedItem.ToString();
                //ddlWingName.SelectedItem.ToString();
                txtWardNo.Text = row[2].ToString();
                txtDescription.Text = row[3].ToString();
                txtRemark.Text = row[4].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }
}
