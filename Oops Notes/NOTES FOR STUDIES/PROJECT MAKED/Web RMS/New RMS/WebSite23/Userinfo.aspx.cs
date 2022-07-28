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

public partial class Userinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS");
        SqlCommand cm = new SqlCommand();

        String sql = "insert into userinfo(username,loginname,password,address,contactno,remark,entrydate)values('" + txtusername.Text + "','" + txtloginname.Text + "','" + txtpassword.Text + "','" + txtaddress.Text + "','" + txtcontactno.Text + "','" + txtremark.Text + "','" + DateTime.Now.ToString() + "')";

        if (txtusername.Text == "")
        {
            lblmsg.Text = "Enter the user name";
            txtusername.Focus();
            return;
        }
        if (txtloginname.Text == "")
        {
            lblmsg.Text = "Enter the login name";
            txtloginname.Focus();
            return;
        }
        if (txtpassword.Text == "")
        {
            lblmsg.Text = "Enter the password";
            txtpassword.Focus();
            return;
        }

        if (txtcpassword.Text == "")
        {
            lblmsg.Text = "Enter the  password again ";
            txtcpassword.Focus();
            return;
        }
        if (txtpassword.Text != txtcpassword.Text)
        {
            lblmsg.Text = "Passward is not matched";
            txtcpassword.Focus();
            return;
        }
        if (txtaddress.Text == "")
        {
            lblmsg.Text = "enter the address";
            txtaddress.Focus();
            return;
        }

        cm.Connection = cnn;
        cm.CommandType = CommandType.Text;
        cm.CommandText = sql;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";
        }
        else
        {
            lblmsg.Text = "data is saved";
            txtusername.Text = "";
            txtloginname.Text = "";
            txtpassword.Text = "";
            txtcpassword.Text = "";
            txtaddress.Text = "";
            txtcontactno.Text = "";
            txtremark.Text = "";
            txtusername.Focus();

        }
    }
   
    protected void  btncheckavailability_Click(object sender, EventArgs e)
{
    SqlConnection cnn = new SqlConnection(@" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS");
        String sql = "select loginname from userinfo where loginname='"+ txtloginname.Text +"'";
        SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
        DataSet ds = new DataSet();
        da.Fill(ds,"a");
        if (ds.Tables["a"].Rows.Count > 0)
        {
            lblmsg.Text = "Login name already exit";
        }
        else
        {
            lblmsg.Text = "Login name is not exit";
            txtloginname.Text = "";
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
  //  protected void btncheckavailability_Click(object sender, EventArgs e)
    