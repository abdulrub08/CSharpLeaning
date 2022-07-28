using System;
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
using mynewprivate_assembly;
using mynewshared_assembly;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadd_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtfirstno.Text);
        int b = int.Parse(txtsecondno.Text);
        myprivateclass cls = new myprivateclass();
        int c = cls.sum(a, b);
        lblmsg.Text = "Total : "+c;

    }
    protected void btnmulitply_Click(object sender, EventArgs e)
    {
        int a = int.Parse(txtfirstno.Text);
        int b = int.Parse(txtsecondno.Text);
        mynewsharedclass cls1 = new mynewsharedclass();

        int c = cls1.multiply(a, b);
        lblmsg.Text = "Total : " + c;
    }
}
