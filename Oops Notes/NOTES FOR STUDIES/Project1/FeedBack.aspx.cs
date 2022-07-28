using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class FeedBack : System.Web.UI.Page
{
    MyConnectionString css = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        string sql = "Insert into FeedBack(Name,Email_ID,Date_of_Visite,Feed_back_type,Feed_Back_comment)values('" + txtname.Text + "','" + txtemail.Text + "','" + txtdate.Text + "','" + rdbcmmnttype.SelectedItem.ToString() + "','" + txtfeedback.Text + "')";
        int a = 0;
        a = css.DML(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is Not saved";
        }
        else
        {
            txtname.Text = "";
            txtemail.Text = "";
            txtdate.Text = "";
            txtfeedback.Text = "";
            lblmsg.Text = "Data is Saved";
        }
    }
}
