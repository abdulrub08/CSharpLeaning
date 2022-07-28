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

public partial class Companyinfo : System.Web.UI.Page
{
     Class1 cls = new Class1();
     public void ShowGridData()
      {
        string sql = "select id,companyname,address,city,contactno,contactperson,mobileno from companyinfo where activestatus=1";
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


        txtcompanyname.Text = "";
        txtaddress.Text = "";
        txtcity.Text = "";
        txtpincode.Text = "";
        txtcontactno.Text = "";
        txtcontactperson.Text = "";
        txtmobileno.Text = "";
        txtdescription.Text = "";
        txtremark.Text = "";
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        String id = r.Cells[1].Text;
        string sql = "select companyname,address,city,contactno,contactperson,mobileno from companyinfo where id=" + id + "";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtcompanyname.Text = row[0].ToString();
                txtaddress.Text = row[1].ToString();
                txtcity.Text = row[2].ToString();
                txtcontactno.Text = row[3].ToString();
                txtcontactperson.Text = row[4].ToString();
                txtmobileno.Text = row[5].ToString();
                lblid.Text = id;
                lblmode.Text = "update";
                return;
            }
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (txtcompanyname.Text == "")
        {
            lblmsg.Text = "Enter the name of the company:";
            txtcompanyname.Focus();
            return;
        }
        if (txtaddress.Text == "")
        {
            lblmsg.Text = "Enter the address:";
            txtaddress.Focus();
            return;
        }
        if (txtcity.Text == "")
        {
            lblmsg.Text = "Enter the city:";
            txtcity.Focus();
            return;
        }
        string pincode = "";
        if (txtpincode.Text == "")
        {
            pincode = "0";
        }
        else 
        {
            pincode = txtpincode.Text;
            if (pincode.Length != 6)
            {
                lblmsg.Text = "Invalid Pincode";
                txtpincode.Focus();
                return;
            }
            }

        if (txtcontactperson.Text == "")
        {
            lblmsg.Text = "Enter the name of contact person:";
            txtcontactperson.Focus();
            return;
        }
        

        if (txtmobileno.Text == "")
        {
            lblmsg.Text = "Enter the mobile no.:";
            txtmobileno.Focus();
            return;
        }
        string mobileno = "";
        mobileno = txtmobileno.Text;
        if (mobileno.Length != 10)
        {
            lblmsg.Text = "Invalid mobile no";
            txtmobileno.Focus();
            return;
        }
        
        if (lblmode.Text == "save")
        {
            string sql = "insert into companyinfo(companyname,address,city,pincode,contactno,contactperson,mobileno,description,remark,entrydate)values('" + txtcompanyname.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "'," + pincode + ",'" + txtcontactno.Text + "','" + txtcontactperson.Text + "','" + mobileno + "','" + txtdescription.Text + "','" + txtremark.Text + "','" + DateTime.Now.ToString() + "') ";

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
                txtcompanyname.Focus();
                ShowGridData();
            }
        }
        else
        {
            string b = Session["loginname"].ToString();
            SqlCommand cm = new SqlCommand();
            string sql = "update companyinfo set companyname='" + txtcompanyname.Text + "',address='" + txtaddress.Text + "',city='" + txtcity.Text + "',contactno='" + txtcontactno.Text + "',contactperson='" + txtcontactperson.Text + "',description='" + txtdescription.Text + "',remark='" + txtremark.Text + "'where id="+ lblid.Text +"";
            int a = 0;
            a = cls.ExecuteQuery(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not updated";
            }
            else
            {
                lblmsg.Text = "Data is updated";
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
