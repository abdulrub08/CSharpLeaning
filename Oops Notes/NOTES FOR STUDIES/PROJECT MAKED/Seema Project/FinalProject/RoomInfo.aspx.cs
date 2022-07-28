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

public partial class RoomInfo : System.Web.UI.Page
{
    public void ShowGridData()
    {
        string sql = "select FloorNo,WingName,WardNo,RoomNo,Description,EntryDate,id from RoomInfo where ActiveStatus=1";
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
                actives = row[6].ToString();
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
        if (txtRoomNo.Text == "")
        {
            lblmsg.Text = "Please enter the Room No";
            txtRoomNo.Focus();
            return;
        }
        if (lblmode.Text == "Save")
        {
            string sql = "insert into RoomInfo(FloorNo,WingName,WardNo,RoomNo,Description,Remark,EntryDate,EntryPerson)values('" + ddlFloorNo.SelectedItem.ToString() + "','" + ddlWingName.SelectedItem.ToString() + "','" + ddlWardNo.SelectedItem.ToString() + "','" + txtRoomNo.Text + "','" + txtDescription.Text + "','" + txtRemark.Text + "','" + Session["cdate"].ToString() + "','" + Session["LoginName"].ToString() + "')";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Saved ";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Saved";
                //ddlFloorNo.Items.Clear();
                ddlWingName.Items.Clear();
                ddlWardNo.Items.Clear();
                txtRoomNo.Text = "";
                txtDescription.Text = "";
                txtRemark.Text = "";
                ShowGridData();
            }
        }
        else
        {
            string sql = "update RoomInfo set FloorNo='" + ddlFloorNo.SelectedItem.ToString() + "',WingName='" + ddlWingName.SelectedItem.ToString() + "',WardNo='" + ddlWardNo.SelectedItem.ToString() + "',RoomNo='" + txtRoomNo.Text + "',Description='" + txtDescription.Text + "',Remark='" + txtRemark.Text + "'where id='"+ lblid.Text +"'";
            int a = 0;
            a = cs.DML(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not Updated ";
            }
            else
            {
                lblmsg.Text = "Data is Successfully Updated";
                //ddlFloorNo.Items.Clear();
                ddlWingName.Items.Clear();
                ddlWardNo.Items.Clear();
                txtRoomNo.Text = "";
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
    protected void ddlWingName_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select WardNo from WardInfo where WingName='" + ddlWingName.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                ddlWardNo.Items.Add(row[0].ToString());
            }
            break;
        }
        ddlWardNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        string id = r.Cells[7].Text;
        string sql = "select FloorNo,WingName,WardNo,RoomNo,Description,Remark from RoomInfo where id='" + id + "'";
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
                //ddlWardNo.SelectedItem.ToString();
                txtRoomNo.Text = row[3].ToString();
                txtDescription.Text = row[4].ToString();
                txtRemark.Text = row[5].ToString();
                lblid.Text = id;
                lblmode.Text = "Update";
                return;
            }
        }
    }
   
}
