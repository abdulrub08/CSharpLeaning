using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void rbtmale_CheckedChanged(object sender, EventArgs e)
    {
        rbtfemale.Checked = false;
        rbtmale.Checked = true;
    }
    protected void rbtfemale_CheckedChanged(object sender, EventArgs e)
    {
        rbtmale.Checked = false;
        rbtfemale.Checked = true;
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (txtrollnumber.Text == "")
        {
            lblmsg.Text = "enter the rollnumber";
            txtrollnumber.Focus();
            return;
        }
        if (txtstudentname.Text == "")
        {
            lblmsg.Text = "enter the studentname ";
            txtstudentname.Focus();
            return;
        }
        if (rbtmale.Checked == false && rbtfemale.Checked == false)
        {
            lblmsg.Text = "select your gender";
            return;
        }
        if(txtaddress.Text=="")
        {
            lblmsg.Text = "enter the address";
            txtaddress.Focus();
            return;
        }
        if(ddlclass.SelectedIndex==0)
        {
            lblmsg.Text = "select the class";
            ddlclass.Focus();
            return;
        }
        if(txtfathername.Text=="")
        {
            lblmsg.Text = "enter the father's name";
            txtfathername.Focus();
            return;
        }
        if (ddlcast.SelectedIndex == 0)
        {
            lblmsg.Text = "select the cast";
            ddlcast.Focus();
            return;
        }
        
        if (txtfathername.Text == "")
        {
            lblmsg.Text = "enter the father name";
            txtfathername.Focus();
            return;
        }
        if(rbtlhobbies.SelectedItem==null)
        {
            lblmsg.Text = "select the hobbies";
        }
        if(ddloptionalsubject.SelectedIndex==0)
        {
            lblmsg.Text = "select the subject";
            ddloptionalsubject.Focus();
            return;

        }


        lstdetail.Items.Add("Roll No. : "+txtrollnumber.Text);
        lstdetail.Items.Add("Name : " + txtstudentname.Text);
        if(rbtfemale.Checked==true)
        lstdetail.Items.Add("Gender : Female");
        else
            lstdetail.Items.Add("Gender : Male");
        lstdetail.Items.Add("address : " + txtaddress.Text);
        lstdetail.Items.Add("class : " + ddlclass.SelectedItem);
        lstdetail.Items.Add("Father name : " + txtfathername.Text);
        lstdetail.Items.Add(" cast : " + ddlcast.SelectedItem);
        lstdetail.Items.Add("Old school name : " + txtoldschoolname.Text);
        lstdetail.Items.Add("Hobbies : " + rbtlhobbies.SelectedItem);
        lstdetail.Items.Add("Optional subject : " + ddloptionalsubject.SelectedItem);
    }
    protected void btnnew_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}