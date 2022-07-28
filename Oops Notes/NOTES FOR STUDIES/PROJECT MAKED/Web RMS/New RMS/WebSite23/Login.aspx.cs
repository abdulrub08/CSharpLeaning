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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("Userinfo.aspx");

    }
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        if (txtloginname.Text == "admin" && txtpassword.Text == "123")
        {
 
        }
        if (txtloginname.Text == "")
        {
            lblmsg.Text = "Enter the Login name";
            txtloginname.Focus();
            return;
        }
        if (txtpassword.Text == "")
        {
            lblmsg.Text = "Enter the Password";
            txtpassword.Focus();
            return;
        }
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS");

        string sql = "select loginname,password from userinfo where loginname='" + txtloginname.Text + "' and password='" + txtpassword.Text + "' and activestatus=1";

        SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
        DataSet ds = new DataSet();
        da.Fill(ds, "a");
        DataTable dt = ds.Tables["a"];
        if (ds.Tables["a"].Rows.Count > 0)
        {
            Session["loginname"] = txtloginname.Text;
            Response.Redirect("Cdate.aspx");

        }
        
      }
}
