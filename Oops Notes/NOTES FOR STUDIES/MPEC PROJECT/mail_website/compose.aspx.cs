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

public partial class compose : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void lnkaddcc_Click(object sender, EventArgs e)
    {
        lblcc.Visible =Convert.ToBoolean("True");
        txtcc.Visible = Convert.ToBoolean("True");
        }
    protected void lnkaddbcc_Click(object sender, EventArgs e)
    {
        lblbcc.Visible = Convert.ToBoolean("True");
        txtbcc.Visible = Convert.ToBoolean("True");
    }
    //gd
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=VIKAS\SQLEXPRESS");
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string sql = "insert into impound_mail(fromempid,toempid,tocc,tobcc,subject,message,entrydate) values('"+ Session["empid"].ToString() +"','" + txt_to.Text + "','" + txtcc.Text + "','" + txtbcc.Text + "','" + txtsub.Text + "','" + txtmsg.Text + "','"+ DateTime.Now.ToString() +"') ";
        SqlCommand cm = new SqlCommand();
        cm.Connection=cnn;
        cm.CommandText=sql;
        cm.CommandType=CommandType.Text;
        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "data is not saved.";
        }
        else
        {
            lblmsg.Text = "data is saved.";
            
        }


    }
    public bool CheckEmpId(string empid)
    {
        string sql = "select * from userinfo where empid='" + empid + "'";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        if (ds.Tables["a"].Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    Class1 cls = new Class1();
    protected void btnsend_Click(object sender, EventArgs e)
    {

        string sql = "insert into impound_mail(fromempid,toempid,tocc,tobcc,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + txt_to.Text + "','" + txtcc.Text + "','" + txtbcc.Text + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";

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
            lblmsg.Text = "data is not sent.";
        }
        else
        {
            //
           
           // lblmsg.Text = "data is sent.";
            string to, cc, bcc,query;
            bool returnVal;
            if (txt_to.Text != "")
            {
                to = txt_to.Text;
                string[] xto = to.Split(',');
                for (int i = 0; i < xto.Length; i++)
                {
                    returnVal = CheckEmpId(xto[i].ToString());
                    if (returnVal == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.ExecuteQuery(query);

                    }
                    else
                    {
                        query = "insert into outboxmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";

                        cls.ExecuteQuery(query);
                    }
                }
            }
            if (txtcc.Text != "")
            {
                cc = txtcc.Text;
                string[] xcc = cc.Split(',');
                for (int i = 0; i < xcc.Length; i++)
                {
                    returnVal = CheckEmpId(xcc[i].ToString());
                    if (returnVal == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.ExecuteQuery(query);

                    }
                    else
                    {
                        query = "insert into outboxmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";

                        cls.ExecuteQuery(query);
                    }
                }
            }
            if (txtbcc.Text != "")
            {
                bcc = txtbcc.Text;
                string[] xbcc = bcc.Split(',');
                for (int i = 0; i < xbcc.Length; i++)
                {
                    returnVal = CheckEmpId(xbcc[i].ToString());
                    if (returnVal == true)
                    {
                        query = "insert into outboundmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xbcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
                        cls.ExecuteQuery(query);

                    }
                    else
                    {
                        query = "insert into outboxmail(fromempid,toempid,subject,message,entrydate) values('" + Session["empid"].ToString() + "','" + xbcc[i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";


                        cls.ExecuteQuery(query);
                    }
                }
            }
            lblmsg.Text = "data is sent.";
        }
    }
}
