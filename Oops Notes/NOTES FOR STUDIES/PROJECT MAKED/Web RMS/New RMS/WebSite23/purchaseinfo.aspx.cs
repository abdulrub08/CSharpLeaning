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

public partial class purchageinfo : System.Web.UI.Page
{
    Class1 cls = new Class1();
    public void ShowGridData()
    {
        string sql = "select itemname,batchno,mfgdate,expdate,qty,purchaseprice,saleprice,mrp from pinfotemp";
        DataSet ds = new DataSet();
        ds = cls.SelectQuery(sql);
        DataTable dt=ds.Tables["a"];
        GridView1.DataSource=ds.Tables["a"];
        GridView1.DataBind();
    }
  

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        if (txtbatchno.Text == "")
        {
            lblmsg.Text = "Enter the batch no :";
            txtbatchno.Focus();
            return;
        }
        if (txtmfgdate.Text == "")
        {
            lblmsg.Text = "Enter the manufacturing date :";
            txtmfgdate.Focus();
            return;
        }
        if (txtexpdate.Text == "")
        {
            lblmsg.Text = "Enter the Expiry date :";
            txtexpdate.Focus();
            return;
        }
        if (txtqty.Text == "")
        {
            lblmsg.Text = "Enter the Quantity :";
            txtqty.Focus();
            return;
        }
        if (txtpurprice.Text == "")
        {
            lblmsg.Text = "Enter the purchase price";
            txtpurprice.Focus();
            return;
        }
        if (txtsaleprice.Text == "")
        {
            lblmsg.Text = "Enter the sale price :";
            txtsaleprice.Focus();
            return;
        }
        if (txtmrp.Text == "")
        {
            lblmsg.Text = "Enter the market price :";
            txtmrp.Focus();
            return;
        }
        string sql = "insert into pinfotemp(pbillno,partyname,itemname,batchno,mfgdate,expdate,qty,purchaseprice,saleprice,mrp)values('"+ txtpurbillno.Text +"','"+ ddlpartyname.SelectedItem.ToString() +"','"+ddlitemname.SelectedItem.ToString()+"','"+ txtbatchno.Text +"',"+ txtmfgdate.Text +","+ txtexpdate.Text +","+ txtqty.Text +","+ txtpurprice.Text +","+ txtsaleprice.Text +","+ txtmrp.Text +")";
        int a = 0;
        a = cls.ExecuteQuery(sql);
        if (a == 0)
        {
            lblmsg.Text = "Data is not saved";
        }
        else
        {
            lblmsg.Text = "Data is saved successfully";
            


            string pqr = "select itemname,batchno,mfgdate,expdate,qty,purchaseprice,saleprice,mrp from pinfotemp where partyname='"+ ddlpartyname.SelectedItem.ToString() +"' and pbillno='"+ txtpurbillno.Text +"' ";
            DataSet ds = cls.SelectQuery(pqr);
            DataTable dt = ds.Tables["a"];
            GridView1.DataSource = ds.Tables["a"];
            GridView1.DataBind();

            int mul = 0;
            mul = Convert.ToInt32(((int.Parse(txtqty.Text)) *( int.Parse(txtpurprice.Text))));
            lbltopuramount.Text =Convert.ToString (int.Parse(lbltopuramount.Text)+mul);
            txtgrandtotal.Text = lbltopuramount.Text ;

            txtbatchno.Text = "";
            txtmfgdate.Text = "";
            txtexpdate.Text = "";
            txtqty.Text = "";
            txtpurprice.Text = "";
            txtsaleprice.Text = "";
            txtmrp.Text = "";

        }  
    }
    
     
    

   protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
   {

       
   }
   protected void btnsubmit_Click(object sender, EventArgs e)
   {
      
       if (txtpurdate.Text == "")
       {
           lblmsg.Text = "Enter the purchase date";
           txtpurdate.Focus();
           return;
       }
       if (txtpurbillno.Text == "")
       {
           lblmsg.Text = "Enter the purchase billno";
           txtpurbillno.Focus();
           return;
       }
       if (ddlpartyname.SelectedItem.ToString() == "")
       {
           lblmsg.Text = "Select the name of the party";
           ddlpartyname.Focus();
           return;
       }

       SqlConnection cnn = new SqlConnection(@" Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=RMS;Data Source=VIKAS\SQLEXPRESS ");
       SqlCommand cm = new SqlCommand();
       cm.Connection = cnn;
      
       cm.CommandType = CommandType.StoredProcedure;
       cm.CommandText = "sp_pur_insert";

       cm.Parameters.Add("ptype",SqlDbType.VarChar,20);
       cm.Parameters["ptype"].Value = rdbtnpurchasetype.SelectedItem.ToString();

       cm.Parameters.Add("pdate",SqlDbType.DateTime);
       cm.Parameters["pdate"].Value=txtpurdate.Text;

       cm.Parameters.Add("pbillno",SqlDbType.VarChar,30);
       cm.Parameters["pbillno"].Value=txtpurbillno.Text;

       cm.Parameters.Add("partyname",SqlDbType.VarChar,30);
       cm.Parameters["partyname"].Value=ddlpartyname.SelectedItem.ToString();

       cm.Parameters.Add("toamt",SqlDbType.Money,8);
       cm.Parameters["toamt"].Value=lbltopuramount.Text;

       cm.Parameters.Add("tax",SqlDbType.Money,8);
       cm.Parameters["tax"].Value=txttax.Text;

       cm.Parameters.Add("discount",SqlDbType.Money,8);
       cm.Parameters["discount"].Value=txtdiscount.Text;

       cm.Parameters.Add("grandtoamt",SqlDbType.Money,8);
       cm.Parameters["grandtoamt"].Value=txtgrandtotal.Text;

       cm.Parameters.Add("remark",SqlDbType.VarChar,50);
       cm.Parameters["remark"].Value=txtremark.Text;

       cm.Parameters.Add("entrydate",SqlDbType.DateTime);
       cm.Parameters["entrydate"].Value = Session["Cdate"].ToString();

       cm.Parameters.Add("entryperson",SqlDbType.VarChar,50);
       cm.Parameters["entryperson"].Value=Session["loginname"].ToString();

       int a = 0;
       cnn.Open();
       a = cm.ExecuteNonQuery();
       cnn.Close();
       if (a == 0)
       {
           lblmsg.Text = "Data is not saved ";
           
       }
       else
       {
           lblmsg.Text = "Data is saved successfully";
           //rdbtnpurchasetype.Items.Clear();
           txtpurdate.Text = "";
           txtpurbillno.Text = "";
           txtremark.Text = "";
           txttax.Text = "";
           txtdiscount.Text = "";
           txtgrandtotal.Text = "";
           txtmfgdate.Focus();
           
       }
       

   }
}
