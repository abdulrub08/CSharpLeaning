﻿using System;
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
       // lblcc.Visible =Convert.ToBoolean("True");
        lblcc.Visible = true;
        txtcc.Visible = true;
        //  txtcc.Visible = Convert.ToBoolean("True");
        }
    protected void lnkaddbcc_Click(object sender, EventArgs e)
    {
        lblbcc.Visible = true;
        txtbcc.Visible = true;
        
        // lblbcc.Visible = Convert.ToBoolean("True");
        //txtbcc.Visible = Convert.ToBoolean("True");
    }
    //gd
    Class1 cls = new Class1();
    SqlConnection cnn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=mailing;Data Source=vikas\SQLEXPRESS");
   
    protected void btnsave_Click(object sender, EventArgs e)
    {
        string sql = "insert into impound_mail(fromempid,toempid,tocc,tobcc,subject,message,entrydate) values('"+ Session["empid"].ToString() +"','" + txt_to.Text + "','" + txtcc.Text + "','" + txtbcc.Text + "','" + txtsub.Text + "','" + txtmsg.Text + "','"+ DateTime.Now.ToString() +"') ";
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
            lblmsg.Text = "message is not saved.";
        }
        else
        {
            lblmsg.Text = "message is saved.";
            
        }


    }
    //gd to check empid
    
    public bool checkempid(string empid)
    {
        string sql = "select * from userinfo where empid='"+ empid +" ' ";
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

        string sql = "insert into impound_mail(fromempid,toempid,tocc,tobcc,subject,message,entrydate) values('"+ Session["empid"].ToString() +"','" + txt_to.Text + "','" + txtcc.Text + "','" + txtbcc.Text + "','" + txtsub.Text + "','" + txtmsg.Text + "','"+ DateTime.Now.ToString() +"') ";
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
            string to,cc,bcc,query;
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
                        query = "insert into outboundmail(af1,fromempid,toempid,subject,message,entrydate)values('" + lblaf1.Text + "','" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','"+ txtsub.Text +"','"+ txtmsg.Text +"','"+ DateTime .Now.ToString () +"')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";                   
                   
                    }
                    else
                    {
                              query = "insert into outbox(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xto[i].ToString() + "','"+ txtsub.Text +"','"+ txtmsg.Text +"','"+ DateTime .Now.ToString ()+"')";
                        cls.executequery(query);
                        txt_to.Text = "";
                        txtsub.Text = "";
                        txtmsg.Text = "";
                    }
                }
        }
            if (txtcc.Text != "")
            {
                cc=txtcc.Text;
                string [] xcc=cc.Split(',');
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
                        query = "insert into outbox(fromempid,toempid,subject,message,entrydate)values('" + Session["empid"].ToString() + "','" + xbcc [i].ToString() + "','" + txtsub.Text + "','" + txtmsg.Text + "','" + DateTime.Now.ToString() + "')";
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
    protected void txtmsg_TextChanged(object sender, EventArgs e)
    {

    }
    protected void lnkattachfile_Click(object sender, EventArgs e)
    {
        FileUpload1.Visible = true;
        btnupload.Visible = true;
    }
    protected void btnupload_Click(object sender, EventArgs e)
    {
        string fileName = "";
        if (FileUpload1.HasFile)
        {
            fileName = FileUpload1.FileName.ToString();
            
            string uploadFolderPath = "~/";
            string filePath = HttpContext.Current.Server.MapPath(uploadFolderPath);
            FileUpload1.SaveAs(filePath + "\\" + fileName);

            if (lblaf1.Visible == false)
            {
                lblaf1.Text = fileName;
                lblaf1.Visible = true;
            }
            else if (lblaf2.Visible == false)
            {
                lblaf2.Text = fileName;
                lblaf2.Visible = true;
            }
            else if (lblaf3.Visible == false)
            {
                lblaf3.Text = fileName;
                lblaf3.Visible = true;
            }
            else if (lblaf4.Visible == false)
            {
                lblaf4.Text = fileName;
                lblaf4.Visible = true;
            }
            else if (lblaf5.Visible == false)
            {
                lblaf5.Text = fileName;
                lblaf5.Visible = true;
            }
            else
            {

            }

        }
    }
}
