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

public partial class Partyinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    public void ShowGridData()
    {
        string sql = "select id,partyname,address,city,pincode,contactno,personname,mobileno,tinno,paymenttype from partyinfo where activestatus=1";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        GridView1.DataSource=ds.Tables["a"];
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
      if(Page.IsPostBack==false)
      {
          ShowGridData();
          lblid.Text = "";
          lblmode.Text = "save";
      }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        String id=r.Cells[1].Text;
        string sql = "select partyname,address,city,pincode,contactno,personname,mobileno,tinno,paymenttype from partyinfo where id="+ id +"";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtpartyname.Text=row[0].ToString();
                txtaddress.Text = row[1].ToString();
                txtcity.Text=row[2].ToString();
                txtpincode.Text=row[3].ToString();
                txtcontactno.Text=row[4].ToString();
                txtpersonname.Text = row[5].ToString();
                txtmobileno.Text = row[6].ToString();
                txttinno.Text = row[7].ToString();
                ddlpayment.SelectedItem.ToString();
                lblid.Text = id;
                lblmode.Text = "update";
                return;
 
            }
        }
    }
    public void clr()
    {
        txtpartyname.Text = "";
        txtaddress.Text = "";
        txtcity.Text = "";
        txtpincode.Text = "";
        txtcontactno.Text = "";
        txtpersonname.Text = "";
        txtmobileno.Text = "";
        txttinno.Text = "";
        txtremark.Text = "";
    }

    protected void btnsubmit_Click(object sender, EventArgs e)
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
    protected void btnsubmit_Click1(object sender, EventArgs e)
    {
        if (txtpartyname.Text == "")
        {
            lblmsg.Text = "Enter the name of the party:";
            txtpartyname.Focus();
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
            lblmsg.Text = "Enter the name of the city:";
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
                lblmsg.Text = "Invalid Pincode.";
                txtpincode.Focus();
                return;
            }
        }
        if (txtpersonname.Text == "")
        {
            lblmsg.Text = "Enter the person name:";
            txtpersonname.Focus();
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
        if (ddlpayment.SelectedIndex == 0)
        {
            lblmsg.Text = "Select the payment type:";
            ddlpayment.Focus();
            return;
        }
        if (lblmode.Text == "save")
        {
            string sql = "insert into partyinfo(partyname,address,city,pincode,contactno,personname,mobileno,tinno,paymenttype,remark,entrydate)values('" + txtpartyname.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "'," + pincode + ",'" + txtcontactno.Text + "','" + txtpersonname.Text + "','" + mobileno+ "','" + txttinno.Text + "','" + ddlpayment.SelectedItem.ToString() + "','" + txtremark.Text + "','" + DateTime.Now.ToString() + "')";
            SqlCommand cm = new SqlCommand();
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
                txtpartyname.Focus();
                ShowGridData();

            }
        }
        else
        {
            string b = Session["loginname"].ToString();
            SqlCommand cm = new SqlCommand();
            string sql = "update partyinfo set partyname='" + txtpartyname.Text + "',address='" + txtaddress.Text + "',city='" + txtcity.Text + "',pincode="+ pincode +",contactno='" + txtcontactno.Text + "',personname='" + txtpersonname.Text + "',mobileno='" + txtmobileno.Text + "',tinno='" + txttinno.Text + "',paymenttype='" + ddlpayment.SelectedItem.ToString() + "' where id=" + lblid.Text + "";
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
}
