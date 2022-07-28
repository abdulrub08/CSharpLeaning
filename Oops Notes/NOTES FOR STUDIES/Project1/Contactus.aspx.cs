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

public partial class Contactus : System.Web.UI.Page
{
    MyConnectionString css = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (txtname.Text == "")
        {
            lblname.Text = "Missing Your Name";
            txtname.Focus();
            return;
        }
        if (txtemail.Text == "")
        {
            lblemail.Text = "Missing You Email-ID";
            txtemail.Focus();
            return;
        }
        if (txtmblno.Text == "")
        {
            lblmobile.Text = "Missing Mobile No";
            txtmblno.Focus();
            return;
        }
        if (txtcmmnt.Text == "")
        {
            lblmsg.Text = "Plz Enter Your Comment";
            txtcmmnt.Focus();
            return;
        }


        string sql = "Insert into Contact_US(Name,Email_ID,Mobile_No,Comment)values('" + txtname.Text + "','" + txtemail.Text + "'," + txtmblno.Text + ",'" + txtcmmnt.Text + "')";
        int a = 0;
        a = css.DML(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is Not Saved";
        }
        else
        {
            txtcmmnt.Text = "";
            txtemail.Text = "";
            txtmblno.Text = "";
            txtname.Text = "";
            lblmsg.Text = "Data is Saved";
        }
    }
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        
    }
}
