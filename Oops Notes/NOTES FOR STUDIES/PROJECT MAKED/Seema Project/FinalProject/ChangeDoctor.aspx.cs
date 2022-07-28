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

public partial class ChangeDoctor : System.Web.UI.Page
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
            string sql = "select DoctorName from DoctorInfo where ActiveStatus=1 ";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ddlDoctorName.Items.Add(row[0].ToString());
                }
                break;
            }
            ddlDoctorName.Items.Insert(0, new ListItem("--Please Select--", "0"));
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
    protected void btnChangeDoctor_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        btnSubmit.Visible = true;
    }
    public void ShowGrid()
    {
        string sql = "select RegNo,DoctorName,StartDate,EndDate,IPDFee,TotalDays,EntryDate,EntryPerson,id from AddDoctor where ActiveStatus=1 and RegNo='" + ddlRegNo.SelectedItem.ToString() + "'";
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
                actives = row[8].ToString();
                break;
            }
        }
    }
    protected void ddlRegNo_SelectedIndexChanged(object sender, EventArgs e)
    {
        ShowGrid();
    }
    protected void ddlDoctorName_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select DoctorName,Speciality,IPDFee,Address,emailid,ContactNo from DoctorInfo where DoctorName='" + ddlDoctorName.SelectedItem.ToString() + "'";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DetailsView1.DataSource = ds.Tables["a"];
        DetailsView1.DataBind();
        DataTable dt = ds.Tables["a"];
        string activestate = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                activestate = row[5].ToString();
                lblIPDFee.Text = row[2].ToString();
                break;
            }
        }
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Project1;Data Source=AAA\SQLEXPRESS");
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "STPAddDoctor";

        cm.Parameters.Add("RegNo",SqlDbType.VarChar,30);
        cm.Parameters["RegNo"].Value = ddlRegNo.SelectedItem.ToString();

        cm.Parameters.Add("DoctorName", SqlDbType.VarChar, 30);
        cm.Parameters["DoctorName"].Value = ddlDoctorName.SelectedItem.ToString();

        cm.Parameters.Add("StartDate", SqlDbType.DateTime);
        cm.Parameters["StartDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("IPDFee",SqlDbType.Money);
        cm.Parameters["IPDFee"].Value = lblIPDFee.Text;

        cm.Parameters.Add("EntryDate", SqlDbType.DateTime);
        cm.Parameters["EntryDate"].Value = Session["cdate"].ToString();

        cm.Parameters.Add("EntryPerson", SqlDbType.VarChar,30);
        cm.Parameters["EntryPerson"].Value = Session["LoginName"].ToString();

        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not Saved";
        }
        else
        {
            lblmsg.Text = "Data is Saved";
            ShowGrid();
        }
        Panel2.Visible = false;
        btnSubmit.Visible = false;
        
    }
}
