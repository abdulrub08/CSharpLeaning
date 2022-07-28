using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HOME1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            if (Session["loginName"].ToString() == "Admin")
            {
                LinkButton1.Visible = true;
            }
            else
            {
                LinkButton1.Visible = false;
            }
        }
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ADUser.aspx");
    }
    protected void LinkButton18_Click(object sender, EventArgs e)
    {
        Session["mode"] = "Save";
        Response.Redirect("AddExpense.aspx");

    }
    protected void LinkButton19_Click(object sender, EventArgs e)
    {
        Session["mode"] = "Save";
        Response.Redirect("AddPayment.aspx");
    }
    protected void LinkButton22_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        Response.Redirect("ExpenseInfo.aspx");
    }
}