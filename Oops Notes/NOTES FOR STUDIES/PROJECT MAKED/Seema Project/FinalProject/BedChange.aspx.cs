using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class BedChange : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel2.Visible = false;
            btnSubmit.Visible = false;
        }
        if (Page.IsPostBack == false)
        {
            string sql = "select RegNo from Registration where ActiveStatus=1 ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlRegNo.Items.Add(row[0].ToString());
                }
                break;
            }
            ddlRegNo.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
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
                    rbtlFloorNo.Items.Add(row[0].ToString());
                }
                break;
            }
        }
    }
    public void ShowGrid()
    {
        string sql = "select RegNo,BedNo,StartDate,EndDate,BedCharges,TotalDays,EntryDate,id from AddBed where ActiveStatus=1 and RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
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
                actives = row[7].ToString();
                break;
            }
        }
    }
    protected void ddlRegNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowGrid();
    }
    protected void rbtlFloorNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlWingName.Items.Clear();
        rbtlWardNo.Items.Clear();
        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select WingName from WingInfo where FloorNo='" + rbtlFloorNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlWingName.Items.Add(row[0].ToString());
            }
            break;
        }
    }
    protected void rbtlWingName_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlWardNo.Items.Clear();
        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select WardNo from WardInfo where WingName='" + rbtlWingName.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlWardNo.Items.Add(row[0].ToString());
            }
            break;
        } 
    }
    protected void rbtlWardNo_SelectedIndexChanged(object sender, EventArgs e)
    {

        rbtlRoomNo.Items.Clear();
        rbtlBedNo.Items.Clear();
        string sql = "select RoomNo from RoomInfo where WardNo='" + rbtlWardNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlRoomNo.Items.Add(row[0].ToString());
            }
            break;
        }
    }
    protected void rbtlRoomNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        rbtlBedNo.Items.Clear();
        string sql = "select BedNo from BedInfo where RoomNo='" + rbtlRoomNo.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                rbtlBedNo.Items.Add(row[0].ToString());
            }
            break;
        }
    }
    
    protected void btnChangeBed_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        btnSubmit.Visible = true;
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "STPAddBed";

        cm.Parameters.Add("RegNo", SqlDbType.VarChar,30);
        cm.Parameters["RegNo"].Value = ddlRegNo.SelectedItem.ToString();


        cm.Parameters.Add("StartDate", SqlDbType.DateTime);
        cm.Parameters["StartDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("BedNo", SqlDbType.VarChar, 30);
        cm.Parameters["BedNo"].Value = rbtlBedNo.SelectedItem.ToString();

        cm.Parameters.Add("EntryDate", SqlDbType.DateTime);
        cm.Parameters["EntryDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("EntryPerson", SqlDbType.VarChar, 30);
        cm.Parameters["EntryPerson"].Value = Session["LoginName"].ToString();
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved.";
        }
        else
        {
            lblmsg.Text = "Data is saved.";
            ShowGrid();
        }

        Panel2.Visible = false;
        btnSubmit.Visible = false;
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
