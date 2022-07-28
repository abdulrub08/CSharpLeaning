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

public partial class inbox : System.Web.UI.Page
{
    //gd
    Class1 cls = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            string sql = "select fromempid,subject,entrydate as Date from outboundmail where toempid='"+ Session["empid"].ToString() +"' ";
            DataSet ds = new DataSet();
            ds = cls.selectquery(sql);
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();
            btnsave.Visible = true;
            btnsend.Text = "Forward";
        }


    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Panel5.Visible = true;
        GridView1.Visible = false;
        GridViewRow r = GridView1.SelectedRow;
        string sql = "SELECT     fromempid, subject, message, af1, af2, af3, af4, af5 FROM outboundmail where toempid='" + Session["empid"].ToString() + "' and fromempid='" + r.Cells[1].Text + "' and subject='" + r.Cells[2].Text + "' and entrydate='" + r.Cells[3].Text + "'";
        DataSet ds = new DataSet();
        ds = cls.selectquery(sql);
        DataTable dt=ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txt_to.Text = row[0].ToString();
                txtsub.Text = row[1].ToString();
                txtmsg.Text = row[2].ToString();
                break;
            }
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        btnsave.Visible = false;
        btnsend.Text = "Send";
        txtmsg.Text = "";
        txtsub.Text = "";
    }
    protected void lnkattachfile_Click(object sender, EventArgs e)
    {

    }
    protected void lnkaddcc_Click(object sender, EventArgs e)
    {

    }
    protected void lnkaddbcc_Click(object sender, EventArgs e)
    {

    }
    protected void btnsend_Click(object sender, EventArgs e)
    {

    }
}
