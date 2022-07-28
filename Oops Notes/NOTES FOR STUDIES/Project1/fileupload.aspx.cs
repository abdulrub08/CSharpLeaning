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

public partial class fileupload : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("~/Career/") + FileUpload1.FileName);
                Label1.Text = "file" + " " + FileUpload1.FileName + " " + " is Uploaded";
            }

        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
}
