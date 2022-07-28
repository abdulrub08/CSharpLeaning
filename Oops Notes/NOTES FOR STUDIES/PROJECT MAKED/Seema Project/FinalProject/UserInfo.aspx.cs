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

public partial class UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    MyConnectionString cs=new MyConnectionString();
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        txtUserName.Focus();
        if (txtUserName.Text == "")
        {
            lblmsg.Text = "Please Enter the User name";
            txtUserName.Focus();
            return;
        }
        if (txtLoginName.Text == "")
        {
            lblmsg.Text = "Please Enter the Login name";
            txtLoginName.Focus();
            return;
        }
        if (txtPassword.Text == "")
        {
            lblmsg.Text = "Please Enter the Password";
            txtPassword.Focus();
            return;
        }
        if (txtConfirmPassword.Text == "")
        {
            lblmsg.Text = "Please Enter the Confirm Password";
            txtConfirmPassword.Focus();
            return;
        }
        if (txtPassword.Text != txtConfirmPassword.Text)
        {
            lblmsg.Text = "Password is not matching";
            txtConfirmPassword.Text = "";
            txtConfirmPassword.Focus();
            return;
        }
        if (txtAddress.Text == "")
        {
            lblmsg.Text = "Please Enter the Address";
            txtAddress.Focus();
            return;
        }
        if (txtContactNo.Text == "")
        {
            lblmsg.Text = "Please Enter the ContactNo";
            txtContactNo.Focus();
            return;
        }

        System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
        byte[] data = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text);
        data = x.ComputeHash(data);
        string md5hash = System.Text.Encoding.ASCII.GetString(data);
        Label1.Text = md5hash;

        string sql = "insert into UserInfo(mobileno,UserName,LoginName,Password,Address,ContactNo,Remark,EntryDate)values("+ txtMobileNo.Text +",'" + txtUserName.Text + "','" + txtLoginName.Text + "','" + md5hash + "','" + txtAddress.Text + "','" + txtContactNo.Text + "','" + txtRemark.Text + "','" + DateTime.Now.ToString() + "')";

        int a = 0;
        a = cs.DML(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";

        }
        else
        {
            lblmsg.Text = "Data is successfully saved";
            Response.Redirect("Welcome.aspx");
            txtUserName.Text = "";
            txtLoginName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            txtRemark.Text = "";

        }
        if (txtCaptcha.Text != "")
        {
            if (Session["randomStr"].ToString() == txtCaptcha.Text)
            {
                Response.Write("successful submission by Human");
            }
            else
            {
                Response.Write("Enter correct characters as shown in image.");
            }
        }
        else
        {
            Response.Write("Please enter characters shown in image in textbox");
        }
    }
        
    protected void btnCheckAvailability_Click(object sender, EventArgs e)
    {
        string sql = "select LoginName from UserInfo where LoginName='"+ txtLoginName.Text +"'";
        DataSet ds= new DataSet();
        ds = cs.SelectOuery(sql);
        if(ds.Tables["a"].Rows.Count>0)
        {
            lblmsg.Text=txtLoginName.Text + " is already exist ";
            txtLoginName.Focus();
            return;
        }
        else
        {
            lblmsg.Text="you can proceed with this login name";
        }
        
    }
}
