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
using System.Data.SqlClient;

public partial class rGroupinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void join(object sender, EventArgs e)
    {
        ddlgroupname.Items.Insert(0,"--Select the group name--");
    }
    protected void btnprintall_Click(object sender, EventArgs e)
    {
        string sql = "select groupname,description from groupinfo";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforgroup.aspx");

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string sql = "select groupname,description from groupinfo where groupname='"+ ddlgroupname.SelectedItem.ToString() +"'";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        Session["mydataset"] = ds;
        Response.Redirect("Reportforgroup.aspx");

    }
}
