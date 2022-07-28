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

public partial class usreinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if(txtusername.Text== "")
        {
            lblmsg.Text = "Enter the user name";
            txtusername.Focus();
            return;
        }
        if ( txtempid.Text == "")
        {
            lblmsg.Text = "Enter the employee id";
            txtempid.Focus();
            return;
        } 
        if (txtpwd.Text == "")
        {
            lblmsg.Text = "Enter the password";
            txtpwd.Focus();
            return;
        } 
        if (txtcpwd.Text == "")
        {
            lblmsg.Text = "Enter the confirm password field";
            txtcpwd.Focus();
            return;
        } 
        if (txtcpwd.Text != txtpwd.Text)
        {
            lblmsg.Text = "Enter the coreect password";
            txtpwd.Text = "";
            txtcpwd.Text = "";
            txtpwd.Focus();
           
            return;
        }
        if ( txtdesignation.Text == "")
        {
            lblmsg.Text = "Enter your designation";
             txtdesignation.Focus();
            return;
        } 
        if (txtcno.Text == "")
        {
            lblmsg.Text = "Enter your contact number";
            txtcno.Focus();
            return;
        } 

        //database conn.
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=VIKAS\SQLEXPRESS");

        string sql = "insert into userinfo(username,empid,password,designation,address,contactno,remark,entrydate)values('"+ txtusername.Text +"','"+ txtempid.Text +"','"+ txtpwd.Text +"','"+ txtdesignation.Text +"','"+ txtaddress.Text +"','"+ txtcno.Text +"','"+ txtremark.Text +"','"+ DateTime.Now.ToString() +"') ";
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.Text;
        cm.CommandText = sql;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "data is not submitted";
        }
        else
        {
            //lblmsg.Text = "data is saved";
            Response.Redirect("home.aspx");
        }
        
    }
}
