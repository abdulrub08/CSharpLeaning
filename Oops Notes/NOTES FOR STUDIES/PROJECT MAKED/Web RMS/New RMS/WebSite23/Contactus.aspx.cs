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

public partial class Contactus : System.Web.UI.Page
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
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "insert into contactus(name,address,mobileno,emailid,description,contacttimefrom,contacttimeto,entrydate)values('" + txtname.Text + "','" + txtaddress.Text + "','" + txtmobileno.Text + "','" + txtemailid.Text + "','" + txtdescription.Text + "','" + ddlfromtiming.SelectedItem.ToString()+"','"+ ddltotime.SelectedItem.ToString() +"','" + DateTime.Now.ToString() + "')";
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully...";
            txtname.Text = "";
            txtaddress.Text = "";
            txtmobileno.Text = "";
            txtemailid.Text = "";
            txtdescription.Text = "";
            txtname.Focus();
        }

    }
}
