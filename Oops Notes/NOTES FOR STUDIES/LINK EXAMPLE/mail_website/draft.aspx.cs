using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class draft : System.Web.UI.Page
{
    //gd
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "select toempid,subject,entrydate as Date from impound_mail where fromempid='" + Session["empid"].ToString() + "' ";
        DataSet ds = new DataSet();
        ds = cls.selectquery(sql);
        GridView1.DataSource = ds.Tables["a"];
        GridView1.DataBind();
        btnsave.Visible = false;
        btnsend.Text = "Forward";
    }


    protected void lnkaddcc_Click(object sender, EventArgs e)
    {
        lblcc.Visible = true;
        txtcc.Visible = true;
       
    }
    protected void lnkaddbcc_Click(object sender, EventArgs e)
    {
        lblbcc.Visible = true;
        txtbcc.Visible = true;

        
    }
    protected void lnkattachfile_Click(object sender, EventArgs e)
    {

    }

    public bool checkempid(string empid)
    {
        string sql = "select * from userinfo where empid='" + empid + " ' ";
        DataSet ds = new DataSet();
        ds = cls.selectquery(sql);
        if (ds.Tables["a"].Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    protected void btnsend_Click(object sender, EventArgs e)
    {
        SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=vikas\SQLEXPRESS");

        string sql = "insert into impound_mail(fromempid,toempid,tocc,tobcc,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + txt_to.Text + "','" + txtcc.Text + "','" + txtbcc.Text + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "') ";
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandText = sql;
        cm.CommandType = CommandType.Text;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();

        if (a == 0)
        {
            lblmsg.Text = "message is not sent.";
        }
        else
        {
            //lblmsg.Text = "message is sent.";
            string to, cc, bcc, query;
            bool rval;
            if (txt_to.Text != "")
            {
                to = txt_to.Text;
                string[] xto = to.Split(',');
                for (int i = 0; i < xto.Length; i++)
                {
                    rval = checkempid(xto[i].ToString());

                    if (rval == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }
                    else
                    {
                        query = "insert into outbox(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }
                }
            }
            if (txtcc.Text != "")
            {
                cc = txtcc.Text;
                string[] xcc = cc.Split(',');
                for (int i = 0; i < xcc.Length; i++)
                {
                    rval = checkempid(xcc[i].ToString());
                    if (rval == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }
                    else
                    {
                        query = "insert into outbox(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }

                }
            }

            if (txtbcc.Text != "")
            {
                bcc = txtcc.Text;
                string[] xbcc = bcc.Split(',');
                for (int i = 0; i < xbcc.Length; i++)
                {
                    rval = checkempid(xbcc[i].ToString());
                    if (rval == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xbcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";

                    }
                    else
                    {
                        query = "insert into outbox(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xbcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }

                }
            }

            lblmsg.Text = "message is sent";

        }

    }
    protected void btnsave_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

        Panel5.Visible = true;
        GridView1.Visible = false;
        GridViewRow r = GridView1.SelectedRow;
        string sql = "select toempid,tocc,tobcc,subject,message,af1,af2,af3,af4,af5 from impound_mail where fromempid='" + Session["empid"].ToString() + "' and toempid='" + r.Cells[1].Text + "' and subject='" + r.Cells[2].Text + "' and entrydate='" + r.Cells[3].Text + "'";
        DataSet ds = new DataSet();
        ds = cls.selectquery(sql);
        DataTable dt = ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txt_to.Text = row[0].ToString();
                txtsub.Text = row[3].ToString();
                txtmsg.Text = row[4].ToString();
                break;
            }
        }
    }
}
