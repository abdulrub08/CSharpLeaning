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
using System.Data.OleDb;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=retailuser;Initial Catalog=RMS;Data Source=vikas\sqlexpress");
        OleDbCommand cmd = new OleDbCommand("select count(*) from userinfo where loginname='" + txtuser.Text + "' and password='" + txtpwd.Text + "'", cn);
        int cnt;
        cn.Open();
        cnt = int.Parse(cmd.ExecuteScalar().ToString());
        cn.Close();
        System.Threading.Thread.Sleep(3000);
        if (cnt > 0)
            lblmsg.Text = "Valid User..";
        else
            lblmsg.Text = "Invalid username or password.";
    }
}
