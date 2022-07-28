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

public partial class Stocktransfer : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void join(object sender, EventArgs e)
    {
        ddlitemname.Items.Insert(0,"--- Select a Item name -");
    }
    protected void join1(object sender, EventArgs e)
    {
        ddlbatchno.Items.Insert(0,"-- Select the batch no --");
    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        if (ddlitemname.SelectedIndex == 0)
        {
            lblmsg.Text = "Select the Item";
            ddlitemname.Focus();
            return;
        }
        if (ddlbatchno.SelectedIndex == 0)
        {
            lblmsg.Text = "Select the Batchno";
            ddlbatchno.Focus();
            return;
        }
        if (txtqty.Text == "")
        {
            lblmsg.Text = "Enter the Quantity of the item";
            txtqty.Focus();
            return;
        }
        string sql = "insert into sttemp(stdate,stno,itemname,batchno,qty)values('"+ txtstdate.Text +"',"+ txtstno.Text +",'"+ ddlitemname.SelectedItem.ToString() +"','"+ ddlbatchno.SelectedItem.ToString() +"',"+ txtqty.Text +") ";
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";
        }
        else
        {
            lblmsg.Text = "Data is saved";
            string pqr = "select itemname,batchno,qty from sttemp where itemname='"+ ddlitemname.SelectedItem.ToString() +"'";
            DataSet ds = cls.SelectQuery(pqr);
            DataTable dt = ds.Tables["a"];
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();

           // ddlbatchno.Items.Clear();
            //ddlitemname.Items.Clear();
            txtqty.Text = "";

        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS ");
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;

        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "sto_trans";

        cm.Parameters.Add("stdate",SqlDbType.DateTime);
        cm.Parameters["stdate"].Value=txtstdate.Text;

        cm.Parameters.Add("stno",SqlDbType.Int,4);
        cm.Parameters["stno"].Value=txtstno.Text;

        cm.Parameters.Add("remark",SqlDbType.VarChar,50);
        cm.Parameters["remark"].Value=txtremark.Text;

        cm.Parameters.Add("entrydate",SqlDbType.DateTime);
        cm.Parameters["entrydate"].Value=Session["Cdate"].ToString();

        cm.Parameters.Add("entryperson",SqlDbType.VarChar,50);
        cm.Parameters["entryperson"].Value=Session["loginname"].ToString();

        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved...";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully.....";
            txtremark.Text = "";
            txtstdate.Text = "";
            txtstno.Text = "";
            
        }
    }
    protected void ddlitemname_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select batchno from batchwisestock where itemid='" + ddlitemname.SelectedValue + "' and mqty>0";

        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        ddlbatchno.Items.Clear();
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                ddlbatchno.Items.Add(row[0].ToString());
            }
            break;
        }
    }
    protected void ddlbatchno_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select mqty from batchwisestock where batchno='" + ddlbatchno.SelectedItem.ToString() + "' and itemid=" + ddlitemname.SelectedValue + "";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        txtqty.Text = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtqty.Text = row[0].ToString();

            }
            break;
        }
    }
}
