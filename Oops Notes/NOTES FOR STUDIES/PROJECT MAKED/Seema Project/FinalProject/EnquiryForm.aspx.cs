﻿using System;
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

public partial class EnquiryForm : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string sql = "insert into EnquiryForm(Name,Address,MobileNo,EmailID,Subject,EnquiryAbout,EntryDate)values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtMobileNo.Text + "','" + txtEmailID.Text + "','" + txtSubject.Text + "','" + txtEnquiryAbout.Text + "','" + Session["cdate"].ToString() + "')";
        int a = 0;
        a = cs.DML(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not Saved";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully";
            txtName.Text = "";
            txtAddress.Text = "";
            txtMobileNo.Text = "";
            txtEmailID.Text = "";
            txtSubject.Text = "";
            txtEnquiryAbout.Text = "";
        }
    }
}
