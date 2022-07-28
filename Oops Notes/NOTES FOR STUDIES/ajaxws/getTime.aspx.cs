using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getTime : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
//Page_Load ( getTime.aspx )
        Response.Expires = -1;
        Response.Write(DateTime.Now.ToString());
        Response.End();












    }
}
