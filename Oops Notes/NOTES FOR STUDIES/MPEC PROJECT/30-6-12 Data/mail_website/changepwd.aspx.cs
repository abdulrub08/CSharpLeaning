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

public partial class changepwd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //gd
    Class1 cls = new Class1();
    public bool checkoldpwd()
    {
        string sql = "select password from userinfo where empid='"+ Session["empid"].ToString() +"' ";
        DataSet ds = new DataSet();
        ds = cls.selectquery(sql);
        
        if (ds.Tables["a"].Rows.Count> 0)
        {
            return true;
        }
        else
        {            
            return false;
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if(txtoldpwd.Text=="")
        {
            lblmsg.Text = "Please enter your password";
            txtoldpwd.Focus();
            return;
        }
        if (txtnewpwd.Text == "")
        {
            lblmsg.Text = "Please enter your new password";
            txtnewpwd.Focus();
            return;
        }
        if (txtcpwd.Text == "")
        {
            lblmsg.Text = "Please enter your confirm password field";
            txtcpwd.Focus();
            return;
        }
        if (txtcpwd.Text != txtnewpwd.Text)
        {
            lblmsg.Text = "password do not match";
            txtnewpwd.Focus();
            txtcpwd.Text = "";
               return;
        }
       
        
        bool a;
        a = checkoldpwd();
        if (a == true)
        {
            string sql = "update userinfo set password='" + txtnewpwd.Text + "' where empid='" + Session["empid"].ToString() + "'";
            cls.executequery(sql);
            lblmsg.Text = "password has been changed";
        }
        else
        {
            lblmsg.Text = "wrong password given";
        }


    }
}
