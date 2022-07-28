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

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //gd
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=vikas\SQLEXPRESS");
    protected void btnlogin_Click(object sender, EventArgs e)
    {
        string sql = "select activestatus from userinfo where empid='"+ txtempid.Text +"' and password='"+ txtpwd.Text +"' ";
        SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
        DataSet ds = new DataSet();
        da.Fill(ds,"a");
        if (ds.Tables["a"].Rows.Count > 0)
        {
            DataTable dt = ds.Tables["a"];
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row[0].ToString() == "False")
                    {
                        lblmsg.Text = "access denied;contact to adnmin";
                        return;
                    }
                    else
                    {
                        Session["empid"] = txtempid.Text;
                        Response.Redirect("home.aspx");
                    }
                }
            }
        }
        else
       {

           lblmsg.Text = " invalid loginname or password";
        }



    }
}
