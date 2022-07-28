using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page_load
        ScriptManager1.RegisterAsyncPostBackControl(Button4);
        if (ScriptManager1.IsInAsyncPostBack == false)
        {
            lblUpdatePanel.Text = "Full Postback occured at " + DateTime.Now.ToString();
            lblPage.Text = "Full Postback occured at " + DateTime.Now.ToString();
        }
        else
        {
            lblUpdatePanel.Text = "Async. Postback occured at " + DateTime.Now.ToString();
            lblPage.Text = "Async. Postback occured at " + DateTime.Now.ToString();
        }












    }
}



