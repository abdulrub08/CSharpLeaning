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
public partial class Sale : System.Web.UI.Page
{
    Class1 cls = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
       // txtsaledate.Text = DateTime.Now.ToString("dd/mm/yy");
        
    }
    protected void lkhome_Click(object sender, EventArgs e)
    {
        Response.Redirect("Home.aspx");
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");

    }
    protected void ddlitemname_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select batchno from batchwisestock  where itemid='" + ddlitemname.SelectedValue + "' and sqty>0";

        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        ddlbatchno.Items.Clear();
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                ddlbatchno.Items.Add(row[0].ToString());
            }
            break;
        }  
    }
    protected void ddlbatchno_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sql = "select sqty,saleprice from batchwisestock where batchno='" + ddlbatchno.SelectedItem.ToString() + "' and itemid=" + ddlitemname.SelectedValue + "";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt = ds.Tables["a"];
        txtqty.Text = "";
        foreach (DataColumn col in dt.Columns)
        {
            foreach (DataRow row in dt.Rows)
            {
                txtqty.Text = row[0].ToString();
                lblsaleprice.Text = row[1].ToString();

            }
            break;
        }
    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        if (ddlitemname.SelectedIndex == 0)
        {
            lblmsg.Text = "Select the Item";
            ddlitemname.Focus();
            return;
        }
        if (ddlbatchno.SelectedIndex == 0)
        {
            lblmsg.Text = "Select the Batchno";
            ddlbatchno.Focus();
            return;
        }
        if (txtqty.Text == "")
        {
            lblmsg.Text = "Enter the Quantity of the item";
            txtqty.Focus();
            return;
        }
        

        string sql = "insert into sinfotemp(itemname,batchno,qty,saleprice,saledate)values('"+ ddlitemname.SelectedItem.ToString() +"','"+ ddlbatchno.SelectedItem.ToString() +"','"+ txtqty.Text +"',"+ lblsaleprice.Text +",'"+ DateTime.Now.ToString() +"')";
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully...";
          

            string pqr = "select itemname,batchno,qty,saleprice from sinfotemp where itemname='" + ddlitemname.SelectedItem.ToString() + "'";
            DataSet ds = cls.SelectQuery(pqr);
            DataTable dt = ds.Tables["a"];
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();

            double mul = 0;
            int i = int.Parse(txtqty.Text);
            double j = Convert.ToDouble(lblsaleprice.Text);
           // mul = Convert.ToInt32(((int.Parse(txtqty.Text)) * (int.Parse(lblsaleprice.Text))));
            mul = Convert.ToDouble(i * j);
            txtamount.Text = Convert.ToString(Convert.ToDouble(txtamount.Text) + mul);
            txttoamt.Text = txtamount.Text;

        }

    }
    protected void txtqty_TextChanged(object sender, EventArgs e)
    {
        //string sql = "select saleprice from batchwisestock where itemid='"+ ddlitemname.SelectedValue +"' and batchno= '"+ ddlbatchno.SelectedItem.ToString()+"' and sqty="+ txtqty.Text +"";
        //DataSet ds = new DataSet();
        //ds = cls.SelectQuery(sql);
        //DataTable dt=ds.Tables["a"];
        //foreach (DataColumn col in dt.Columns)
        //{
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        lblsaleprice.Text = row[0].ToString();
        //    }
        //    break;
        //}
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        if (txtsaledate.Text == "")
        {
            lblmsg.Text = "Enter the sale date";
            txtsaledate.Focus();
            return;
        }
        if (txtamount.Text == "")
        {
            lblmsg.Text = "Enter the amount";
            txtamount.Focus();
            return;
        }
        if (txttax.Text == "")
        {
            lblmsg.Text = "Enter the tax value";
            txttax.Focus();
            return;
        }
        if (txtdiscount.Text == "")
        {
            lblmsg.Text = "Enter the discount value";
            txtdiscount.Focus();
            return;
        }
        SqlConnection cnn = new SqlConnection(@" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS ");
        SqlCommand cm = new SqlCommand();
        cm.Connection = cnn;
        cm.CommandType = CommandType.StoredProcedure;
        cm.CommandText = "sto_sale";

        cm.Parameters.Add("saletype",SqlDbType.VarChar,10);
        cm.Parameters["saletype"].Value = rbtnsaletype.SelectedItem.ToString();

        cm.Parameters.Add("saledate",SqlDbType.DateTime);
        cm.Parameters["saledate"].Value = txtsaledate.Text;

        cm.Parameters.Add("remark",SqlDbType.VarChar,100);
        cm.Parameters["remark"].Value = txtremark.Text;

        cm.Parameters.Add("amount",SqlDbType.Money);
        cm.Parameters["amount"].Value = txtamount.Text;

        cm.Parameters.Add("tax",SqlDbType.Money);
        cm.Parameters["tax"].Value = txttax.Text;

        cm.Parameters.Add("discount",SqlDbType.Money);
        cm.Parameters["discount"].Value = txtdiscount.Text;

        cm.Parameters.Add("toamount",SqlDbType.Money);
        cm.Parameters["toamount"].Value = txttoamt.Text;

        cm.Parameters.Add("entrydate",SqlDbType.DateTime);
        cm.Parameters["entrydate"].Value=Session["cdate"].ToString();

        cm.Parameters.Add("entryperson",SqlDbType.VarChar,50);
        cm.Parameters["entryperson"].Value = Session["loginname"].ToString();

        int a = 0;
        cnn.Open();
        a = cm.ExecuteNonQuery();
        cnn.Close();
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved..";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully....";
            txtremark.Text = "";
            txtsaledate.Text = "";
            txttax.Text = "";
            txttoamt.Text = "";
            txtamount.Text = "";
            txtdiscount.Text = "";
            txtsaledate.Focus();
        }

    }
    protected void rbtnsaletype_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
