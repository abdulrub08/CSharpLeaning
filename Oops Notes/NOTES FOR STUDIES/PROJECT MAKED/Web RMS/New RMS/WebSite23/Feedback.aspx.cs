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

public partial class Feedback : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "insert into feedback(name,address,mobileno,emailid,description,feedback,entrydate)values('"+ txtname.Text +"','"+ txtaddress.Text +"','"+ txtmobileno.Text +"','"+ txtemailid.Text +"','"+ txtdescription.Text +"',"+ ddlfeedback.SelectedItem.ToString() +",'"+ DateTime.Now.ToString() +"')";
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved....";
        }
        else 
        {
            lblmsg.Text = "Data is saved successfully....";
            txtname.Text = "";
            txtaddress.Text = "";
            txtmobileno.Text = "";
            txtemailid.Text = "";
            txtdescription.Text = "";
            ddlfeedback.Items.Clear();
            txtname.Focus();
        }

    }
}
