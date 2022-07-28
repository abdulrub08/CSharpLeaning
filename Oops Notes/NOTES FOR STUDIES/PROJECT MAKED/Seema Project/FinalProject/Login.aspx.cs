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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    MyConnectionString cs = new MyConnectionString();
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
        data = x.ComputeHash(data);
        string md5hash = System.Text.Encoding.ASCII.GetString(data);
        string sql = "select LoginName,Password from UserInfo where LoginName='" + txtLoginName.Text + "' and ActiveStatus=1";
        DataSet ds = new DataSet();
        ds = cs.SelectOuery(sql);
        DataTable dt = ds.Tables["a"];
        int a = 0;
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                a = 1;
                if (txtLoginName.Text == row[0].ToString() && md5hash == row[1].ToString())
                {
                    Session["LoginName"] = txtLoginName.Text;
                    Response.Redirect("Cdate.aspx");
                }
            }
        }
        if (a == 0)
        {
            lblmsg.Text = "Invalid LoginName or Password ";
        }
    }
    protected void btnSignup_Click(object sender, EventArgs e)
    {
        Response.Redirect("UserInfo.aspx");
    }
}
