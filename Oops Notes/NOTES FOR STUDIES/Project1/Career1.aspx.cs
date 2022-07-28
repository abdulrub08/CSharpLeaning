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

public partial class Career1 : System.Web.UI.Page
{
    MyConnectionString cs = new MyConnectionString();
    protected void Page_Load(object sender, EventArgs e)
    {
        FileUpload1.Visible = false;
        Button1.Visible = false;
        if (Page.IsPostBack == false)
        {
            string sql = "select Job_Profile from Jobprofile";
            DataSet ds = new DataSet();
            ds = cs.SelectOuery(sql);
            DataTable dt;
            dt = ds.Tables["A"];
            DropDownList1.Items.Insert(0, "-select a Job-Profile");
            foreach (DataColumn col in dt.Columns)
            {
                foreach (DataRow row in dt.Rows)
                {
                    DropDownList1.Items.Add(row[0].ToString());
                }
                break;
            }
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Career/") + FileUpload1.FileName);
            Label1.Text = "file" + " " + FileUpload1.FileName + " " + " is Uploaded";
            Label2.Text = FileUpload1.FileName.ToString();
        }
        else
        {
            Label1.Text = "Not Uploaded";
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        FileUpload1.Visible = true;
        Button1.Visible = true;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        //string files = FileUpload1.FileName;
        string sql = "Insert into Career(name,Education,sex,Attachefile,Job_profile)values('" + TextBox1.Text + " " + TextBox2.Text + "','" + TextBox3.Text + "','" + RadioButtonList1.SelectedItem.ToString() + "','" +Label2.Text+ "','" + DropDownList1.SelectedItem.ToString() + "')";
        int a = 0;
        a = cs.DML(sql);
        if (a == 0)
        {
            Label1.Text = "Data is not Saved";
        }
        else
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            Label1.Text = "Data is Saved";
        }
    }
}
