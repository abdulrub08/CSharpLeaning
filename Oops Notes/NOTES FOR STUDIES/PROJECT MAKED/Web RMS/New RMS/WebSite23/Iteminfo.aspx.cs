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
using System.Data.SqlClient;

public partial class Iteminfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    public void ShowGridData()
    {
        string sql = "select id,itemname,companyname,groupname,unitname,openingstock,sqty,srlevel,mqty,mrlevel,mrp,saleprice,remark from iteminfo where activestatus=1";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        GridView1.DataSource=ds.Tables["a"];
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
     if(Page.IsPostBack==false)
     {
         ShowGridData();
         lblid.Text = "";
         lblmode.Text = "save";

     }
       
    }
    public void clr()
    {
        txtitemname.Text = "";
        txtopeningstock.Text = "";
        txtsquantity.Text = "";
        txtsreorder.Text = "";
        txtmquantity.Text = "";
        txtmreorder.Text = "";
        txtmrp.Text = "";
        txtsaleprice.Text = "";
        txtremark.Text = "";
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow r = GridView1.SelectedRow;
        String id = r.Cells[1].Text;
        string sql = "select itemname,companyname,groupname,unitname,openingstock,sqty,srlevel,mqty,mrlevel,mrp,saleprice,remark from iteminfo where id="+ id +"";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt=ds.Tables["a"];
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtitemname.Text=row[0].ToString();
                ddlcompanyname.SelectedItem.ToString();
                ddlgroupname.SelectedItem.ToString();
                ddlunitname.SelectedItem.ToString();
                txtopeningstock.Text = row[4].ToString();
                txtsquantity.Text = row[5].ToString();
                txtsreorder.Text = row[6].ToString();
                txtmquantity.Text = row[7].ToString();
                txtmreorder.Text = row[8].ToString();
                txtmrp.Text = row[9].ToString();
                txtsaleprice.Text = row[10].ToString();
                txtremark.Text = row[11].ToString();
                
 
            }
        }

    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (txtitemname.Text == "")
        {
            lblmsg.Text = "Enter the item name :";
            txtitemname.Focus();
            return;
        }
        if (ddlcompanyname.SelectedIndex==0)
        {
            lblmsg.Text = "Enter the Company name";
            ddlcompanyname.Focus();
            return;
        }
        if (ddlgroupname.SelectedIndex == 0)
        {
            lblmsg.Text = "Enter the Group name";
            ddlgroupname.Focus();
            return;
        }
        if (ddlunitname.SelectedIndex == 0)
        {
            lblmsg.Text = "Enter the unit name";
            ddlunitname.Focus();
            return;
        }
        if (txtopeningstock.Text == "")
        {
            lblmsg.Text = "Enter the opening stock :";
            txtopeningstock.Focus();
            return;
        }
        if (txtsquantity.Text == "")
        {
            lblmsg.Text = "Enter the sale quantity:";
            txtsquantity.Focus();
            return;
        }
        if (txtsreorder.Text == "")
        {
            lblmsg.Text = "Enter the sale reorder level:";
            txtsreorder.Focus();
            return;
        }

        if (txtmquantity.Text == "")
        {
            lblmsg.Text = "Enter the main quantity:";
            txtmquantity.Focus();
            return;
        }

        if (txtmreorder.Text == "")
        {
            lblmsg.Text = "Enter the main reorder level:";
            txtmreorder.Focus();
            return;
        }

        int i = 0;
        i = int.Parse(txtmquantity.Text) + int.Parse(txtsquantity.Text);
        if (int.Parse(txtopeningstock.Text) != i)
        {
            lblmsg.Text = "The sum of sale qty and main qty is not equal to opening stock";
            txtmquantity.Text = "";
            txtsquantity.Text = "";
            txtsquantity.Focus();
            return;
        }
        
        if ((txtmrp.Text == "") && (txtsaleprice.Text == ""))
        {
            txtmrp.Text = "0";
            txtsaleprice.Text = "0";
        }
        if (lblmode.Text == "save")
        {
            string sql = "insert into iteminfo(itemname,companyname,groupname,unitname,openingstock,sqty,srlevel,mqty,mrlevel,mrp,saleprice,remark,entrydate)values('" + txtitemname.Text + "','" + ddlcompanyname.SelectedItem.ToString() + "','" + ddlgroupname.SelectedItem.ToString() + "','" + ddlunitname.SelectedItem.ToString() + "'," + txtopeningstock.Text + "," + txtsquantity.Text + "," + txtsreorder.Text + "," + txtmquantity.Text + "," + txtmreorder.Text + "," + txtmrp.Text + "," + txtsaleprice.Text + ",'" + txtremark.Text + "','" + DateTime.Now.ToString() + "')";
            int a = 0;
            a = cls.ExecuteQuery(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not saved";
            }
            else
            {
                String maxid = "";
                string abc = "select id from iteminfo where id = (select max(id)from iteminfo) ";
                DataSet ds = new DataSet();
                ds = cls.SelectQuery(abc);
                DataTable dt=ds.Tables["a"];
                string bno = "nothing";
                foreach (DataColumn col in dt.Columns)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        maxid = row[0].ToString();
                        break;
 
                    }
                }
                
                string pqr = "insert into batchwisestock(itemid,batchno,mqty,sqty,saleprice,mrp,entrydate)values(" + maxid + ",'" + bno + "'," + txtmquantity.Text + "," + txtsquantity.Text + "," + txtsaleprice.Text + "," + txtmrp.Text + ",'" + DateTime.Now.ToString() + "')";
               // int i = 0;
                i = cls.ExecuteQuery(pqr);
                if (i == 0)
                {
                    lblmsg.Text = "Data is not saved";
                }
                else
                {
                    lblmsg.Text = "Data is saved";
                }
                if (int.Parse(txtmreorder.Text) <= int.Parse(txtmquantity.Text))
                {
                    lblmsg.Text = "Data is Saved but Stock in the main department is going to be end...purchage it ";
                    ShowGridData();
                }
                if (int.Parse(txtsreorder.Text) <= int.Parse(txtsquantity.Text))
                {
                    lblmsg.Text = "Data is saved but Stock in the sale department is going to be end... ";
                    ShowGridData();
                }
                else
                {
                    lblmsg.Text = "Data is saved successfully";
                    ShowGridData();
                }

                clr();
                txtitemname.Focus();
            }
        }
        else
        {
            string b = Session["loginname"].ToString();
            SqlCommand cm = new SqlCommand();
            string sql = ("update iteminfo set,id=" + lblid.Text + " itemname='" + txtitemname.Text + "',companyname='" + ddlcompanyname.SelectedItem.ToString() + "',groupname='" + ddlgroupname.SelectedItem.ToString() + "',unitname='" + ddlunitname.SelectedItem.ToString() + "',openingstock=" + txtopeningstock.Text + ",sqty=" + txtsquantity.Text + ",srlevel=" + txtsreorder.Text + ",mqty=" + txtmquantity.Text + ",mrlevel=" + txtmreorder.Text + ",mrp=" + txtmrp.Text + ",saleprice=" + txtsaleprice.Text + "remark='" + txtremark.Text + "' where id=" + lblid.Text + "");
            int a = 0;
            a = cls.ExecuteQuery(sql);
            if (a == 0)
            {
                lblmsg.Text = "Data is not updated";
            }
            else
            {
                lblmsg.Text = "Data is updated";
                clr();
                ShowGridData();

            }

        }
        
            

        }
    
    protected void ddlcompanyname_SelectedIndexChanged(object sender, EventArgs e)
    {


    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}
