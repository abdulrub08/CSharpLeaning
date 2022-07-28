using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default25 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void NoBot1_GenerateChallengeAndResponse(object sender, AjaxControlToolkit.NoBotEventArgs e)
    {
        //NoBot1_GenerateChallengeAndResponse
//Code as per the requirement... [Condition]



    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Send ( button_click )
        if (NoBot1.IsValid() == true)
            lblmsg.Text = "Thanks for providing your comments.";
        else
            lblmsg.Text = "Already the comments are accepted.";










    }
}
