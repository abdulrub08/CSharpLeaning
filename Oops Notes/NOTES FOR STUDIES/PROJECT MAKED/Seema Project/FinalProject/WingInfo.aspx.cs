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

public partial class WingInfo : System.Web.UI.Page
{
    public void ShowGridData()
    {
        string sql = "select WingName,FloorNo,Description,EntryDate,id from WingInfo where ActiveStatus=1";
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
                actives = row[4].ToString();
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
        if (txtWingName.Text== "")
        {
            lblmsg.Text = "Please enter the Wing Name";
            txtWingName.Focus();
            return;
        }
        if (txtDescription.Text == "")
        {
            lblmsg.Text = "Please the Description";
            txtDescription.Focus();
            return;
        }
        if (lblmode.Text == "Save")
        {
            string sql = "insert into WingInfo(WingName,FloorNo,Description,Remark,EntryDate,EntryPerson)values('" + txtWingName.Text + "','" + ddlFloorNo.SelectedItem.ToString() + "','" + txtDescription.Text + "','" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved";
            }
            else
            {
                lblmsg.Text = "Data is Saved successfully";
                txtWingName.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
        else
        {
            string sql = "update WingInfo set WingName='"+ txtWingName.Text +"',FloorNo='" + ddlFloorNo.SelectedItem.ToString() + "',Description='" + txtDescription.Text + "',Remark='" + txtRemark.Text + "'where id='" + lblid.Text + "'";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated";
            }
            else
            {
                lblmsg.Text = "Data is Updated Successfully";
                txtWingName.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
    }


    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[5].Text;
        string sql = "select WingName,FloorNo,Description,Remark from WingInfo where id='" + id + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtWingName.Text = row[0].ToString();
                ddlFloorNo.SelectedItem.ToString();
                txtDescription.Text = row[2].ToString();
                txtRemark.Text = row[3].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }

    protected void ddlFloorNo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
